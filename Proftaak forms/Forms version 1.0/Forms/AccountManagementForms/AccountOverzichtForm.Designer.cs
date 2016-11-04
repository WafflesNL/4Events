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
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(9, 10);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(84, 39);
            this.btnCreateAccount.TabIndex = 0;
            this.btnCreateAccount.Text = "Account aanmaken";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // lbAccounts
            // 
            this.lbAccounts.FormattingEnabled = true;
            this.lbAccounts.Location = new System.Drawing.Point(98, 10);
            this.lbAccounts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbAccounts.Name = "lbAccounts";
            this.lbAccounts.Size = new System.Drawing.Size(332, 277);
            this.lbAccounts.TabIndex = 1;
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(9, 54);
            this.btnEditAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(84, 39);
            this.btnEditAccount.TabIndex = 3;
            this.btnEditAccount.Text = "Account aanpassen";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.btnChangeAccount_Click);
            // 
            // AccountOverzichtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 301);
            this.Controls.Add(this.btnEditAccount);
            this.Controls.Add(this.lbAccounts);
            this.Controls.Add(this.btnCreateAccount);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AccountOverzichtForm";
            this.Text = "AccountOverzichtForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.ListBox lbAccounts;
        private System.Windows.Forms.Button btnEditAccount;
    }
}