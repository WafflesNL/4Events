namespace Forms_version_1._0.Froms
{
    partial class AccountForm
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
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.tbWachtwoord = new System.Windows.Forms.TextBox();
            this.tbWachtwoord2 = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOudWachtwoord = new System.Windows.Forms.TextBox();
            this.lblAccountinfo = new System.Windows.Forms.Label();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.btnNietOpslaan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(126, 54);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(169, 20);
            this.tbNaam.TabIndex = 0;
            // 
            // tbWachtwoord
            // 
            this.tbWachtwoord.Location = new System.Drawing.Point(126, 133);
            this.tbWachtwoord.Name = "tbWachtwoord";
            this.tbWachtwoord.Size = new System.Drawing.Size(169, 20);
            this.tbWachtwoord.TabIndex = 1;
            // 
            // tbWachtwoord2
            // 
            this.tbWachtwoord2.Location = new System.Drawing.Point(126, 159);
            this.tbWachtwoord2.Name = "tbWachtwoord2";
            this.tbWachtwoord2.Size = new System.Drawing.Size(169, 20);
            this.tbWachtwoord2.TabIndex = 2;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(126, 81);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(169, 20);
            this.tbEmail.TabIndex = 3;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(12, 57);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(35, 13);
            this.lblNaam.TabIndex = 4;
            this.lblNaam.Text = "Naam";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 84);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nieuw Wachtwoord";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Herhaal Wachtwoord";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Oud Wachtwoord";
            // 
            // tbOudWachtwoord
            // 
            this.tbOudWachtwoord.Location = new System.Drawing.Point(126, 107);
            this.tbOudWachtwoord.Name = "tbOudWachtwoord";
            this.tbOudWachtwoord.Size = new System.Drawing.Size(169, 20);
            this.tbOudWachtwoord.TabIndex = 9;
            // 
            // lblAccountinfo
            // 
            this.lblAccountinfo.AutoSize = true;
            this.lblAccountinfo.Location = new System.Drawing.Point(95, 9);
            this.lblAccountinfo.Name = "lblAccountinfo";
            this.lblAccountinfo.Size = new System.Drawing.Size(96, 13);
            this.lblAccountinfo.TabIndex = 10;
            this.lblAccountinfo.Text = "Account Informatie";
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(227, 323);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(68, 44);
            this.btnOpslaan.TabIndex = 11;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            // 
            // btnNietOpslaan
            // 
            this.btnNietOpslaan.Location = new System.Drawing.Point(12, 324);
            this.btnNietOpslaan.Name = "btnNietOpslaan";
            this.btnNietOpslaan.Size = new System.Drawing.Size(68, 43);
            this.btnNietOpslaan.TabIndex = 12;
            this.btnNietOpslaan.Text = "Niet Opslaan";
            this.btnNietOpslaan.UseVisualStyleBackColor = true;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 379);
            this.Controls.Add(this.btnNietOpslaan);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.lblAccountinfo);
            this.Controls.Add(this.tbOudWachtwoord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbWachtwoord2);
            this.Controls.Add(this.tbWachtwoord);
            this.Controls.Add(this.tbNaam);
            this.Name = "AccountForm";
            this.Text = "Accountinformatie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.TextBox tbWachtwoord;
        private System.Windows.Forms.TextBox tbWachtwoord2;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOudWachtwoord;
        private System.Windows.Forms.Label lblAccountinfo;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Button btnNietOpslaan;
    }
}