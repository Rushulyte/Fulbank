using System;
using System.Windows.Forms;

namespace Fulbank
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register Register = new Register();
            Register.Show();
            this.Hide();
        }
        
        private void Login_Closing(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}