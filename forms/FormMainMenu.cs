using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olympiad.forms
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            Hide();
            fl.ShowDialog();
            Close();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblTime.Text = dateTime.ToString("hh:mm");
        }
    }
}
