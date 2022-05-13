using System.ComponentModel;

namespace Fulbank
{
    partial class Login
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
            this.linkToRegister = new System.Windows.Forms.LinkLabel();
            this.psswdLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.psswdTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.linkToRegister);
            this.GroupBox.Controls.Add(this.psswdLabel);
            this.GroupBox.Controls.Add(this.idLabel);
            this.GroupBox.Controls.Add(this.psswdTextBox);
            this.GroupBox.Controls.Add(this.idTextBox);
            this.GroupBox.Location = new System.Drawing.Point(55, 41);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(316, 193);
            this.GroupBox.TabIndex = 0;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Connexion";
            // 
            // linkToRegister
            // 
            this.linkToRegister.Location = new System.Drawing.Point(12, 148);
            this.linkToRegister.Name = "linkToRegister";
            this.linkToRegister.Size = new System.Drawing.Size(298, 23);
            this.linkToRegister.TabIndex = 4;
            this.linkToRegister.TabStop = true;
            this.linkToRegister.Text = "Vous n\'avez pas de compte? Inscrivez-vous";
            this.linkToRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // psswdLabel
            // 
            this.psswdLabel.Location = new System.Drawing.Point(12, 94);
            this.psswdLabel.Name = "psswdLabel";
            this.psswdLabel.Size = new System.Drawing.Size(100, 20);
            this.psswdLabel.TabIndex = 3;
            this.psswdLabel.Text = "Mot de passe";
            // 
            // idLabel
            // 
            this.idLabel.Location = new System.Drawing.Point(12, 40);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(100, 20);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "Identifiant";
            // 
            // psswdTextBox
            // 
            this.psswdTextBox.Location = new System.Drawing.Point(118, 94);
            this.psswdTextBox.Name = "psswdTextBox";
            this.psswdTextBox.Size = new System.Drawing.Size(143, 20);
            this.psswdTextBox.TabIndex = 1;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(118, 40);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(143, 20);
            this.idTextBox.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 287);
            this.Controls.Add(this.GroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.Text = "Login";
            this.Closing += new CancelEventHandler(this.Login_Closing);
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox psswdTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label psswdLabel;
        private System.Windows.Forms.LinkLabel linkToRegister;

        private System.Windows.Forms.GroupBox GroupBox;

        #endregion
    }
}