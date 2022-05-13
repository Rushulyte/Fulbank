using System;
using System.Windows.Forms;

namespace Fulbank.Pages
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginPage = new();
            loginPage.Show();
            Hide();
        }

        private void Register_Closing(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}