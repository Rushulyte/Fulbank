using System;
using System.Windows.Forms;
using Fulbank.Classes;

namespace Fulbank.Pages;

public partial class Connection : Form
{
    public Database db = new Database();
    
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
        db.setName(nameTextBox.Text);
        db.setHost(hostTextBox.Text);
        db.setUser(userTextBox.Text);
        db.setPassword(psswdTextBox.Text);
        db.createConnection();
        if (db.testConnection(db.getConnection()))
        {
            Login loginPage = new();
            loginPage.Show();
            Hide();
        }
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
        nameTextBox.Clear();
        hostTextBox.Clear();
        userTextBox.Clear();
        psswdTextBox.Clear();
    }
}