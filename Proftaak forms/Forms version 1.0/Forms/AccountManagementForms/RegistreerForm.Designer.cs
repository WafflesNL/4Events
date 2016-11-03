namespace Forms_version_1._0
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
            this.tbRFIDTag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(222, 217);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 44);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Opslaan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblAccountinfo
            // 
            this.lblAccountinfo.AutoSize = true;
            this.lblAccountinfo.Location = new System.Drawing.Point(89, 12);
            this.lblAccountinfo.Name = "lblAccountinfo";
            this.lblAccountinfo.Size = new System.Drawing.Size(103, 13);
            this.lblAccountinfo.TabIndex = 26;
            this.lblAccountinfo.Text = "Registreer informatie";
            // 
            // lblReapeatPassword
            // 
            this.lblReapeatPassword.AutoSize = true;
            this.lblReapeatPassword.Location = new System.Drawing.Point(7, 132);
            this.lblReapeatPassword.Name = "lblReapeatPassword";
            this.lblReapeatPassword.Size = new System.Drawing.Size(108, 13);
            this.lblReapeatPassword.TabIndex = 23;
            this.lblReapeatPassword.Text = "Herhaal Wachtwoord";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(7, 106);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(101, 13);
            this.lblNewPassword.TabIndex = 22;
            this.lblNewPassword.Text = "Nieuw Wachtwoord";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(7, 82);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(84, 13);
            this.lblUserName.TabIndex = 21;
            this.lblUserName.Text = "Gebruikersnaam";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(7, 55);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(35, 13);
            this.lblNaam.TabIndex = 20;
            this.lblNaam.Text = "Naam";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(121, 80);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(169, 20);
            this.tbUserName.TabIndex = 19;
            // 
            // tbRepeatPassword
            // 
            this.tbRepeatPassword.Location = new System.Drawing.Point(121, 130);
            this.tbRepeatPassword.Name = "tbRepeatPassword";
            this.tbRepeatPassword.Size = new System.Drawing.Size(169, 20);
            this.tbRepeatPassword.TabIndex = 18;
            this.tbRepeatPassword.UseSystemPasswordChar = true;
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(121, 104);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(169, 20);
            this.tbNewPassword.TabIndex = 17;
            this.tbNewPassword.UseSystemPasswordChar = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(121, 52);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(169, 20);
            this.tbName.TabIndex = 16;
            // 
            // lblFunction
            // 
            this.lblFunction.AutoSize = true;
            this.lblFunction.Location = new System.Drawing.Point(7, 160);
            this.lblFunction.Name = "lblFunction";
            this.lblFunction.Size = new System.Drawing.Size(42, 13);
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
            this.cbFunction.Location = new System.Drawing.Point(121, 158);
            this.cbFunction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFunction.Name = "cbFunction";
            this.cbFunction.Size = new System.Drawing.Size(169, 21);
            this.cbFunction.TabIndex = 29;
            this.cbFunction.Visible = false;
            // 
            // tbRFIDTag
            // 
            this.tbRFIDTag.Enabled = false;
            this.tbRFIDTag.Location = new System.Drawing.Point(121, 184);
            this.tbRFIDTag.Name = "tbRFIDTag";
            this.tbRFIDTag.Size = new System.Drawing.Size(169, 20);
            this.tbRFIDTag.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "RFID Tag";
            // 
            // RegistreerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 273);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRFIDTag);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegistreerForm";
            this.Text = "RegistreerForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClose);
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
        private System.Windows.Forms.TextBox tbRFIDTag;
        private System.Windows.Forms.Label label1;
    }
}