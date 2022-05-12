using System;
using System.Windows.Forms;

namespace Fulbank
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login Login = new Login();
            Login.Show();
            this.Hide();
        }

        private void Register_Closing(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}