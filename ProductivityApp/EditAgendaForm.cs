using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductivityApp
{
    public partial class EditAgendaForm : Form
    {

        public HomeInterface homePage;

        public EditAgendaForm(HomeInterface homePage)
        {
            InitializeComponent();
            this.homePage = homePage;
        }

        private void back_Click(object sender, EventArgs e)
        {
            homePage.panel1.Controls.Remove(this);
        }
    }
}
