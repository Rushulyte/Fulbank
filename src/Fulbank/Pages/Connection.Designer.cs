using System.ComponentModel;

namespace Fulbank.Pages;

partial class Connection
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.GroupBox = new System.Windows.Forms.GroupBox();
        this.buttonCancel = new System.Windows.Forms.Button();
        this.hostTextBox = new System.Windows.Forms.TextBox();
        this.hostLabel = new System.Windows.Forms.Label();
        this.buttonConnect = new System.Windows.Forms.Button();
        this.userLabel = new System.Windows.Forms.Label();
        this.userTextBox = new System.Windows.Forms.TextBox();
        this.psswdLabel = new System.Windows.Forms.Label();
        this.nameLabel = new System.Windows.Forms.Label();
        this.psswdTextBox = new System.Windows.Forms.TextBox();
        this.nameTextBox = new System.Windows.Forms.TextBox();
        this.GroupBox.SuspendLayout();
        this.SuspendLayout();
        // 
        // GroupBox
        // 
        this.GroupBox.Controls.Add(this.buttonCancel);
        this.GroupBox.Controls.Add(this.hostTextBox);
        this.GroupBox.Controls.Add(this.hostLabel);
        this.GroupBox.Controls.Add(this.buttonConnect);
        this.GroupBox.Controls.Add(this.userLabel);
        this.GroupBox.Controls.Add(this.userTextBox);
        this.GroupBox.Controls.Add(this.psswdLabel);
        this.GroupBox.Controls.Add(this.nameLabel);
        this.GroupBox.Controls.Add(this.psswdTextBox);
        this.GroupBox.Controls.Add(this.nameTextBox);
        this.GroupBox.Location = new System.Drawing.Point(51, 40);
        this.GroupBox.Name = "GroupBox";
        this.GroupBox.Size = new System.Drawing.Size(316, 254);
        this.GroupBox.TabIndex = 1;
        this.GroupBox.TabStop = false;
        this.GroupBox.Text = "Base de données";
        // 
        // buttonCancel
        // 
        this.buttonCancel.Location = new System.Drawing.Point(118, 206);
        this.buttonCancel.Name = "buttonCancel";
        this.buttonCancel.Size = new System.Drawing.Size(75, 23);
        this.buttonCancel.TabIndex = 9;
        this.buttonCancel.Text = "Annuler";
        this.buttonCancel.UseVisualStyleBackColor = true;
        this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
        // 
        // hostTextBox
        // 
        this.hostTextBox.Location = new System.Drawing.Point(118, 73);
        this.hostTextBox.Name = "hostTextBox";
        this.hostTextBox.Size = new System.Drawing.Size(143, 20);
        this.hostTextBox.TabIndex = 8;
        // 
        // hostLabel
        // 
        this.hostLabel.Location = new System.Drawing.Point(12, 73);
        this.hostLabel.Name = "hostLabel";
        this.hostLabel.Size = new System.Drawing.Size(100, 20);
        this.hostLabel.TabIndex = 7;
        this.hostLabel.Text = "Hôte";
        // 
        // buttonConnect
        // 
        this.buttonConnect.Location = new System.Drawing.Point(12, 206);
        this.buttonConnect.Name = "buttonConnect";
        this.buttonConnect.Size = new System.Drawing.Size(75, 23);
        this.buttonConnect.TabIndex = 6;
        this.buttonConnect.Text = "Connexion";
        this.buttonConnect.UseVisualStyleBackColor = true;
        this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
        // 
        // userLabel
        // 
        this.userLabel.Location = new System.Drawing.Point(12, 122);
        this.userLabel.Name = "userLabel";
        this.userLabel.Size = new System.Drawing.Size(100, 20);
        this.userLabel.TabIndex = 5;
        this.userLabel.Text = "Utilisateur";
        // 
        // userTextBox
        // 
        this.userTextBox.Location = new System.Drawing.Point(118, 122);
        this.userTextBox.Name = "userTextBox";
        this.userTextBox.Size = new System.Drawing.Size(143, 20);
        this.userTextBox.TabIndex = 4;
        // 
        // psswdLabel
        // 
        this.psswdLabel.Location = new System.Drawing.Point(12, 160);
        this.psswdLabel.Name = "psswdLabel";
        this.psswdLabel.Size = new System.Drawing.Size(100, 20);
        this.psswdLabel.TabIndex = 3;
        this.psswdLabel.Text = "Mot de passe";
        // 
        // nameLabel
        // 
        this.nameLabel.Location = new System.Drawing.Point(12, 40);
        this.nameLabel.Name = "nameLabel";
        this.nameLabel.Size = new System.Drawing.Size(100, 20);
        this.nameLabel.TabIndex = 2;
        this.nameLabel.Text = "Nom";
        // 
        // psswdTextBox
        // 
        this.psswdTextBox.Location = new System.Drawing.Point(118, 160);
        this.psswdTextBox.Name = "psswdTextBox";
        this.psswdTextBox.Size = new System.Drawing.Size(143, 20);
        this.psswdTextBox.TabIndex = 1;
        this.psswdTextBox.UseSystemPasswordChar = true;
        // 
        // nameTextBox
        // 
        this.nameTextBox.Location = new System.Drawing.Point(118, 40);
        this.nameTextBox.Name = "nameTextBox";
        this.nameTextBox.Size = new System.Drawing.Size(143, 20);
        this.nameTextBox.TabIndex = 0;
        // 
        // Connection
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(430, 331);
        this.Controls.Add(this.GroupBox);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
        this.Name = "Connection";
        this.Text = "Connection";
        this.Load += new System.EventHandler(this.Connection_Load);
        this.GroupBox.ResumeLayout(false);
        this.GroupBox.PerformLayout();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button buttonConnect;
    private System.Windows.Forms.Label hostLabel;
    private System.Windows.Forms.TextBox hostTextBox;
    private System.Windows.Forms.Button buttonCancel;

    private System.Windows.Forms.Label userLabel;
    private System.Windows.Forms.TextBox userTextBox;

    private System.Windows.Forms.GroupBox GroupBox;
    private System.Windows.Forms.Label psswdLabel;
    private System.Windows.Forms.Label nameLabel;
    private System.Windows.Forms.TextBox psswdTextBox;
    private System.Windows.Forms.TextBox nameTextBox;

    #endregion
}