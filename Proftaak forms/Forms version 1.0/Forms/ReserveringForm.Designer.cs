namespace Forms_version_1._0.Forms
{
    partial class ReserveringForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.tbBedrag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAccount = new System.Windows.Forms.ListBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(197, 226);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(12, 226);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Accepteer";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // tbBedrag
            // 
            this.tbBedrag.Enabled = false;
            this.tbBedrag.Location = new System.Drawing.Point(102, 191);
            this.tbBedrag.Name = "tbBedrag";
            this.tbBedrag.Size = new System.Drawing.Size(170, 20);
            this.tbBedrag.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bedrag";
            // 
            // lbAccount
            // 
            this.lbAccount.FormattingEnabled = true;
            this.lbAccount.Location = new System.Drawing.Point(102, 12);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(173, 160);
            this.lbAccount.TabIndex = 6;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(12, 64);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(47, 13);
            this.lblAccount.TabIndex = 7;
            this.lblAccount.Text = "Account";
            // 
            // ReserveringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lbAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBedrag);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnBack);
            this.Name = "ReserveringForm";
            this.Text = "ReserveringForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox tbBedrag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbAccount;
        private System.Windows.Forms.Label lblAccount;
    }
}