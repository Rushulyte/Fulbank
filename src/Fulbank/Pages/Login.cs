using System;
using System.Windows.Forms;

namespace Fulbank.Pages;

public partial class Login : Form
{
    public Login()
    {
        InitializeComponent();
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Register registerPage = new();
        registerPage.Show();
        Hide();
    }
        
    private void Login_Closing(object sender, EventArgs e)
    {
        Application.Exit();
    }
}