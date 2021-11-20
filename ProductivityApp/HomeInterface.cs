using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductivityApp
{
    public partial class HomeInterface : Form
    {
        public HomeInterface()
        {
            InitializeComponent();
            Form1 homePage = new Form1(this);
            homePage.TopLevel = false;
            homePage.FormBorderStyle = FormBorderStyle.None;
            homePage.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(homePage);
            this.panel1.Tag = homePage;
            homePage.BringToFront();
            homePage.Show();
        }
    }
}
