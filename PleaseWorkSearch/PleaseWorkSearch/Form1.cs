using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PleaseWorkSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listcollection.Clear();
            string[] listItems = { "league.exe", "chrome.exe", "sus.exe", "bruh.exe", "bruhchungus.exe", "brick.exe", "f" };
            foreach (string app in listItems)
            {
                listBox1.Items.Add(app);
            }
            foreach (string str in listBox1.Items)
            {
                listcollection.Add(str);
                
            }

        }

        List<string> listcollection = new List<string>();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == false)
            {
                listBox1.Items.Clear();
                foreach (string str in listcollection)
                {
                    
                    if (str.StartsWith(textBox1.Text))
                    {
                        listBox1.Items.Add(str);
                    }
                }
            }
            else if (textBox1.Text == "")
            {
                listBox1.Items.Clear();
                foreach (string str in listcollection)
                {
                    listBox1.Items.Add(str);
                }
            }

        }
    }
}
