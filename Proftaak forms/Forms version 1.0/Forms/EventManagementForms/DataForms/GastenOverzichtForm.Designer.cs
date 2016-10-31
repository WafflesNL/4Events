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
            this.lbGuestList = new System.Windows.Forms.ListBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAanwezig = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnInChecken = new System.Windows.Forms.Button();
            this.btnUitChecken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbGuestList
            // 
            this.lbGuestList.FormattingEnabled = true;
            this.lbGuestList.ItemHeight = 16;
            this.lbGuestList.Location = new System.Drawing.Point(16, 31);
            this.lbGuestList.Margin = new System.Windows.Forms.Padding(4);
            this.lbGuestList.Name = "lbGuestList";
            this.lbGuestList.Size = new System.Drawing.Size(379, 340);
            this.lbGuestList.TabIndex = 0;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(12, 7);
            this.lblNaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(45, 17);
            this.lblNaam.TabIndex = 1;
            this.lblNaam.Text = "Naam";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(67, 7);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(104, 17);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Betalingsstatus";
            // 
            // lblAanwezig
            // 
            this.lblAanwezig.AutoSize = true;
            this.lblAanwezig.Location = new System.Drawing.Point(179, 7);
            this.lblAanwezig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAanwezig.Name = "lblAanwezig";
            this.lblAanwezig.Size = new System.Drawing.Size(68, 17);
            this.lblAanwezig.TabIndex = 5;
            this.lblAanwezig.Text = "Aanwezig";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(402, 31);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(108, 44);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnInChecken
            // 
            this.btnInChecken.Location = new System.Drawing.Point(402, 81);
            this.btnInChecken.Name = "btnInChecken";
            this.btnInChecken.Size = new System.Drawing.Size(108, 44);
            this.btnInChecken.TabIndex = 7;
            this.btnInChecken.Text = "Inchecken";
            this.btnInChecken.UseVisualStyleBackColor = true;
            this.btnInChecken.Click += new System.EventHandler(this.btnInChecken_Click);
            // 
            // btnUitChecken
            // 
            this.btnUitChecken.Location = new System.Drawing.Point(402, 131);
            this.btnUitChecken.Name = "btnUitChecken";
            this.btnUitChecken.Size = new System.Drawing.Size(108, 44);
            this.btnUitChecken.TabIndex = 8;
            this.btnUitChecken.Text = "Uitchecken";
            this.btnUitChecken.UseVisualStyleBackColor = true;
            this.btnUitChecken.Click += new System.EventHandler(this.btnUitChecken_Click);
            // 
            // GastenOverzichtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 386);
            this.Controls.Add(this.btnUitChecken);
            this.Controls.Add(this.btnInChecken);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblAanwezig);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.lbGuestList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GastenOverzichtForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GastenOverzichtForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbGuestList;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAanwezig;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnInChecken;
        private System.Windows.Forms.Button btnUitChecken;
    }
}