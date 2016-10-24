namespace Forms_version_1._0.Forms
{
    partial class GastenOverzichtForm
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
            this.GastenOverzichtLijst = new System.Windows.Forms.ListBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnAanwezig = new System.Windows.Forms.Button();
            this.btnNietAanwezig = new System.Windows.Forms.Button();
            this.lblAanwezig = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GastenOverzichtLijst
            // 
            this.GastenOverzichtLijst.FormattingEnabled = true;
            this.GastenOverzichtLijst.Location = new System.Drawing.Point(12, 25);
            this.GastenOverzichtLijst.Name = "GastenOverzichtLijst";
            this.GastenOverzichtLijst.Size = new System.Drawing.Size(175, 225);
            this.GastenOverzichtLijst.TabIndex = 0;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(9, 6);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(35, 13);
            this.lblNaam.TabIndex = 1;
            this.lblNaam.Text = "Naam";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(50, 6);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(78, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Betalingsstatus";
            // 
            // btnAanwezig
            // 
            this.btnAanwezig.Location = new System.Drawing.Point(193, 25);
            this.btnAanwezig.Name = "btnAanwezig";
            this.btnAanwezig.Size = new System.Drawing.Size(99, 25);
            this.btnAanwezig.TabIndex = 3;
            this.btnAanwezig.Text = "Aanwezig";
            this.btnAanwezig.UseVisualStyleBackColor = true;
            this.btnAanwezig.Click += new System.EventHandler(this.btnAanwezig_Click);
            // 
            // btnNietAanwezig
            // 
            this.btnNietAanwezig.Location = new System.Drawing.Point(193, 56);
            this.btnNietAanwezig.Name = "btnNietAanwezig";
            this.btnNietAanwezig.Size = new System.Drawing.Size(99, 25);
            this.btnNietAanwezig.TabIndex = 4;
            this.btnNietAanwezig.Text = "Niet Aanwezig";
            this.btnNietAanwezig.UseVisualStyleBackColor = true;
            this.btnNietAanwezig.Click += new System.EventHandler(this.btnNietAanwezig_Click);
            // 
            // lblAanwezig
            // 
            this.lblAanwezig.AutoSize = true;
            this.lblAanwezig.Location = new System.Drawing.Point(134, 6);
            this.lblAanwezig.Name = "lblAanwezig";
            this.lblAanwezig.Size = new System.Drawing.Size(53, 13);
            this.lblAanwezig.TabIndex = 5;
            this.lblAanwezig.Text = "Aanwezig";
            // 
            // GastenOverzichtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 262);
            this.Controls.Add(this.lblAanwezig);
            this.Controls.Add(this.btnNietAanwezig);
            this.Controls.Add(this.btnAanwezig);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.GastenOverzichtLijst);
            this.Name = "GastenOverzichtForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GastenOverzichtForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox GastenOverzichtLijst;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnAanwezig;
        private System.Windows.Forms.Button btnNietAanwezig;
        private System.Windows.Forms.Label lblAanwezig;
    }
}