namespace Forms_version_1._0
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblGebruikersNaam = new System.Windows.Forms.Label();
            this.lblWachtwoord = new System.Windows.Forms.Label();
            this.pb4Events = new System.Windows.Forms.PictureBox();
            this.lblInlogstatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb4Events)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 248);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(187, 276);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(259, 22);
            this.textBox2.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(253, 304);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(122, 50);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // lblGebruikersNaam
            // 
            this.lblGebruikersNaam.AutoSize = true;
            this.lblGebruikersNaam.Location = new System.Drawing.Point(52, 248);
            this.lblGebruikersNaam.Name = "lblGebruikersNaam";
            this.lblGebruikersNaam.Size = new System.Drawing.Size(117, 17);
            this.lblGebruikersNaam.TabIndex = 3;
            this.lblGebruikersNaam.Text = "Gebruikersnaam:";
            // 
            // lblWachtwoord
            // 
            this.lblWachtwoord.AutoSize = true;
            this.lblWachtwoord.Location = new System.Drawing.Point(52, 276);
            this.lblWachtwoord.Name = "lblWachtwoord";
            this.lblWachtwoord.Size = new System.Drawing.Size(90, 17);
            this.lblWachtwoord.TabIndex = 4;
            this.lblWachtwoord.Text = "Wachtwoord:";
            // 
            // pb4Events
            // 
            this.pb4Events.Image = global::Forms_version_1._0.Properties.Resources._4Events;
            this.pb4Events.Location = new System.Drawing.Point(187, 12);
            this.pb4Events.Name = "pb4Events";
            this.pb4Events.Size = new System.Drawing.Size(259, 191);
            this.pb4Events.TabIndex = 5;
            this.pb4Events.TabStop = false;
            // 
            // lblInlogstatus
            // 
            this.lblInlogstatus.AutoSize = true;
            this.lblInlogstatus.ForeColor = System.Drawing.Color.Red;
            this.lblInlogstatus.Location = new System.Drawing.Point(184, 218);
            this.lblInlogstatus.Name = "lblInlogstatus";
            this.lblInlogstatus.Size = new System.Drawing.Size(283, 17);
            this.lblInlogstatus.TabIndex = 6;
            this.lblInlogstatus.Text = "Het inloggen is mislukt probeer het opnieuw";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 366);
            this.Controls.Add(this.lblInlogstatus);
            this.Controls.Add(this.pb4Events);
            this.Controls.Add(this.lblWachtwoord);
            this.Controls.Add(this.lblGebruikersNaam);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pb4Events)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblGebruikersNaam;
        private System.Windows.Forms.Label lblWachtwoord;
        private System.Windows.Forms.PictureBox pb4Events;
        private System.Windows.Forms.Label lblInlogstatus;
    }
}

