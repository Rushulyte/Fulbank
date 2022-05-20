using System;
using System.Windows.Forms;
using Fulbank.Classes;

namespace Fulbank.Pages;

public partial class Connection : Form
{
    public Database Db = new Database();
    
    public Connection()
    {
        InitializeComponent();
    }
    
    private void Connection_Load(object sender, EventArgs e)
    {
        // TODO
    }

    private void buttonConnect_Click(object sender, EventArgs e)
    {
        Db.SetName(nameTextBox.Text);
        Db.SetHost(hostTextBox.Text);
        Db.SetUser(userTextBox.Text);
        Db.SetPassword(psswdTextBox.Text);
        Db.CreateConnection();
        if (!Db.TestConnection(Db.GetConnection())) return;
        Login loginPage = new();
        loginPage.Show();
        Hide();
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
        nameTextBox.Clear();
        hostTextBox.Clear();
        userTextBox.Clear();
        psswdTextBox.Clear();
    }
}