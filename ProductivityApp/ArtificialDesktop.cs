using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductivityApp
{
    public partial class ArtificialDesktop : Form
    {

        private int authorizedAppCount;
        private DateTime startTime;
        private Agenda currentAgenda;
        private Event currentEvent;
        //private DetectApp currentTracker;

        private Dictionary<string, int> timeSpentOnApp;
        private string appTimes = "app_times.properties";

        [DllImport("user32.dll")]
        private static extern int FindWindow(string className, string windowText);

        [DllImport("user32.dll")]
        private static extern int ShowWindow(int hwnd, int command);

        [DllImport("user32.dll")]
        public static extern int FindWindowEx(int parentHandle, int childAfter, string className, int windowTitle);

        [DllImport("user32.dll")]
        private static extern int GetDesktopWindow();

        private const int SW_HIDE = 0;
        private const int SW_SHOW = 1;

        public ArtificialDesktop()
        {
            InitializeComponent();
            timeSpentOnApp = new Dictionary<string, int>();
            startTime = DateTime.Now;
            currentAgenda = GlobalSchedule.GetCurrentAgenda();
            currentEvent = currentAgenda.GetAllEvents().Peek();
            authorizedAppCount = currentEvent.GetAuthorizedApps().Count;
            //this.currentTracker = currentTracker;

            this.BackColor = Color.FromArgb(30, 30, 30);
            this.flowLayoutPanel1.BackColor = Color.FromArgb(30, 30, 30);
            this.exitButton.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan difference = DateTime.Now.Subtract(startTime);
            if (Math.Abs(difference.TotalMinutes - currentEvent.GetTimeFrame())<=0.5)
            {
                this.Close();
                currentAgenda.GetAllEvents().Dequeue();
                //currentTracker.Dispose();
                if (currentAgenda.GetAllEvents().Count > 0)
                {
                    ArtificialDesktop focusMode = new ArtificialDesktop();
                    focusMode.Show();
                }
                else
                {
                    int hwnd = FindWindow("Shell_TrayWnd", "");
                    ShowWindow(hwnd, SW_SHOW);
                }
            }
        }

        private void ArtificialDesktop_Load(object sender, EventArgs e)
        {
            int btnLength = (int)(this.Size.Height * (0.13));       //Length of each button in proportion to Form size
            int margin = btnLength /8;        //Margin between each button in proportion to button size
            int count = 0;
            foreach (string appRoot in currentEvent.GetAuthorizedApps())     //Adds buttons to the panel
            {
                Button current = new Button();
                current.Size = new Size(btnLength, (int)(btnLength/1.5));
                current.Click += new EventHandler(this.button_click);
                current.MouseEnter += new EventHandler(this.mouse_Enter);
                current.MouseLeave += new EventHandler(this.mouse_Leave);
                current.Margin = new Padding(margin, margin, margin, margin);
                current.Cursor = Cursors.Hand;
                current.Name = "Allowed App " + (count + 1);
                current.FlatStyle = FlatStyle.Flat;
                current.Text = Form1.GetAppName(appRoot);
                current.Font = new Font(label1.Font.Name, 10);
                current.BackColor = Color.FromArgb(30, 30, 30);
                current.ForeColor = Color.Gainsboro;
                
                flowLayoutPanel1.Controls.Add(current);
                count++;
            }
            
        }

        private void mouse_Leave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(30, 30, 30);
            btn.ForeColor = Color.Gainsboro;
        }

        private void mouse_Enter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Gainsboro;
            btn.ForeColor = Color.Black;
        }

        private void button_click(object sender, EventArgs e)       //Runs when dynamic buttons are clicked
        {
            Button btn = (Button)sender;
            Process.Start(AllowedApps.appNameInRoot[btn.Text]);
            int hwnd = FindWindow("Shell_TrayWnd", "");
            ShowWindow(hwnd, SW_HIDE);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("Are you sure you want to exit this event? Doing so will end the agenda.", "Warning", MessageBoxButtons.YesNo);
            if (exit == DialogResult.Yes)
            {
                this.Close();
                //currentTracker.Dispose()
                int hwnd = FindWindow("Shell_TrayWnd", "");
                ShowWindow(hwnd, SW_SHOW);
                Application.Exit();

            }
        }

        private void timer_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
