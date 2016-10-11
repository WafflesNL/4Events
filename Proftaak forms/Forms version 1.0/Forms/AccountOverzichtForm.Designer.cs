namespace Forms_version_1._0
{
    partial class AccountOverzichtForm
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
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.lbAccounts = new System.Windows.Forms.ListBox();
            this.btnRemoveAccount = new System.Windows.Forms.Button();
            this.btnChangeAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(12, 12);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(112, 48);
            this.btnCreateAccount.TabIndex = 0;
            this.btnCreateAccount.Text = "Account aanmaken";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // lbAccounts
            // 
            this.lbAccounts.FormattingEnabled = true;
            this.lbAccounts.ItemHeight = 16;
            this.lbAccounts.Location = new System.Drawing.Point(130, 12);
            this.lbAccounts.Name = "lbAccounts";
            this.lbAccounts.Size = new System.Drawing.Size(442, 340);
            this.lbAccounts.TabIndex = 1;
            // 
            // btnRemoveAccount
            // 
            this.btnRemoveAccount.Location = new System.Drawing.Point(12, 120);
            this.btnRemoveAccount.Name = "btnRemoveAccount";
            this.btnRemoveAccount.Size = new System.Drawing.Size(112, 48);
            this.btnRemoveAccount.TabIndex = 2;
            this.btnRemoveAccount.Text = "Account Verwijderen";
            this.btnRemoveAccount.UseVisualStyleBackColor = true;
            this.btnRemoveAccount.Click += new System.EventHandler(this.btnRemoveAccount_Click);
            // 
            // btnChangeAccount
            // 
            this.btnChangeAccount.Location = new System.Drawing.Point(12, 66);
            this.btnChangeAccount.Name = "btnChangeAccount";
            this.btnChangeAccount.Size = new System.Drawing.Size(112, 48);
            this.btnChangeAccount.TabIndex = 3;
            this.btnChangeAccount.Text = "Account aanpassen";
            this.btnChangeAccount.UseVisualStyleBackColor = true;
            this.btnChangeAccount.Click += new System.EventHandler(this.btnChangeAccount_Click);
            // 
            // AccountOverzichtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 370);
            this.Controls.Add(this.btnChangeAccount);
            this.Controls.Add(this.btnRemoveAccount);
            this.Controls.Add(this.lbAccounts);
            this.Controls.Add(this.btnCreateAccount);
            this.Name = "AccountOverzichtForm";
            this.Text = "AccountOverzichtForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.ListBox lbAccounts;
        private System.Windows.Forms.Button btnRemoveAccount;
        private System.Windows.Forms.Button btnChangeAccount;
    }
}