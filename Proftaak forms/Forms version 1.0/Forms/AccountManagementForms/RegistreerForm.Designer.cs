﻿namespace Forms_version_1._0
{
    partial class RegistreerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAccountinfo = new System.Windows.Forms.Label();
            this.lblReapeatPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbRepeatPassword = new System.Windows.Forms.TextBox();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblFunction = new System.Windows.Forms.Label();
            this.cbFunction = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(294, 233);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 54);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Opslaan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblAccountinfo
            // 
            this.lblAccountinfo.AutoSize = true;
            this.lblAccountinfo.Location = new System.Drawing.Point(119, 15);
            this.lblAccountinfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountinfo.Name = "lblAccountinfo";
            this.lblAccountinfo.Size = new System.Drawing.Size(140, 17);
            this.lblAccountinfo.TabIndex = 26;
            this.lblAccountinfo.Text = "Registreer informatie";
            // 
            // lblReapeatPassword
            // 
            this.lblReapeatPassword.AutoSize = true;
            this.lblReapeatPassword.Location = new System.Drawing.Point(9, 163);
            this.lblReapeatPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReapeatPassword.Name = "lblReapeatPassword";
            this.lblReapeatPassword.Size = new System.Drawing.Size(140, 17);
            this.lblReapeatPassword.TabIndex = 23;
            this.lblReapeatPassword.Text = "Herhaal Wachtwoord";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(9, 131);
            this.lblNewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(128, 17);
            this.lblNewPassword.TabIndex = 22;
            this.lblNewPassword.Text = "Nieuw Wachtwoord";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(9, 101);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(113, 17);
            this.lblUserName.TabIndex = 21;
            this.lblUserName.Text = "Gebruikersnaam";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(9, 68);
            this.lblNaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(45, 17);
            this.lblNaam.TabIndex = 20;
            this.lblNaam.Text = "Naam";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(161, 98);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(224, 22);
            this.tbUserName.TabIndex = 19;
            // 
            // tbRepeatPassword
            // 
            this.tbRepeatPassword.Location = new System.Drawing.Point(161, 160);
            this.tbRepeatPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbRepeatPassword.Name = "tbRepeatPassword";
            this.tbRepeatPassword.Size = new System.Drawing.Size(224, 22);
            this.tbRepeatPassword.TabIndex = 18;
            this.tbRepeatPassword.UseSystemPasswordChar = true;
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(161, 128);
            this.tbNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(224, 22);
            this.tbNewPassword.TabIndex = 17;
            this.tbNewPassword.UseSystemPasswordChar = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(161, 64);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(224, 22);
            this.tbName.TabIndex = 16;
            // 
            // lblFunction
            // 
            this.lblFunction.AutoSize = true;
            this.lblFunction.Location = new System.Drawing.Point(9, 197);
            this.lblFunction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFunction.Name = "lblFunction";
            this.lblFunction.Size = new System.Drawing.Size(54, 17);
            this.lblFunction.TabIndex = 28;
            this.lblFunction.Text = "Functie";
            this.lblFunction.Visible = false;
            // 
            // cbFunction
            // 
            this.cbFunction.FormattingEnabled = true;
            this.cbFunction.Items.AddRange(new object[] {
            "Beheerder",
            "Bezoeker",
            "Medewerker",
            "Accountbeheerder"});
            this.cbFunction.Location = new System.Drawing.Point(161, 194);
            this.cbFunction.Name = "cbFunction";
            this.cbFunction.Size = new System.Drawing.Size(224, 24);
            this.cbFunction.TabIndex = 29;
            this.cbFunction.Visible = false;
            // 
            // RegistreerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 300);
            this.Controls.Add(this.cbFunction);
            this.Controls.Add(this.lblFunction);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAccountinfo);
            this.Controls.Add(this.lblReapeatPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.tbRepeatPassword);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.tbName);
            this.Name = "RegistreerForm";
            this.Text = "RegistreerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblAccountinfo;
        private System.Windows.Forms.Label lblReapeatPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbRepeatPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblFunction;
        private System.Windows.Forms.ComboBox cbFunction;
    }
}