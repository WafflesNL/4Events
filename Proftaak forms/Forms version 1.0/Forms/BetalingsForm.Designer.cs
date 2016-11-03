namespace Forms_version_1._0.Forms
{
    partial class BetalingsForm
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
            this.btnBetalen = new System.Windows.Forms.Button();
            this.lblKosten = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblKostenDB = new System.Windows.Forms.Label();
            this.lblReserve = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBetalen
            // 
            this.btnBetalen.Enabled = false;
            this.btnBetalen.Location = new System.Drawing.Point(296, 99);
            this.btnBetalen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBetalen.Name = "btnBetalen";
            this.btnBetalen.Size = new System.Drawing.Size(100, 28);
            this.btnBetalen.TabIndex = 2;
            this.btnBetalen.Text = "Betalen";
            this.btnBetalen.UseVisualStyleBackColor = true;
            this.btnBetalen.Click += new System.EventHandler(this.btnBetalen_Click);
            // 
            // lblKosten
            // 
            this.lblKosten.AutoSize = true;
            this.lblKosten.Location = new System.Drawing.Point(15, 66);
            this.lblKosten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKosten.Name = "lblKosten";
            this.lblKosten.Size = new System.Drawing.Size(52, 17);
            this.lblKosten.TabIndex = 4;
            this.lblKosten.Text = "Kosten";
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(15, 11);
            this.lblEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(44, 17);
            this.lblEvent.TabIndex = 5;
            this.lblEvent.Text = "Event";
            // 
            // lblKostenDB
            // 
            this.lblKostenDB.AutoSize = true;
            this.lblKostenDB.Location = new System.Drawing.Point(72, 66);
            this.lblKostenDB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKostenDB.Name = "lblKostenDB";
            this.lblKostenDB.Size = new System.Drawing.Size(36, 17);
            this.lblKostenDB.TabIndex = 6;
            this.lblKostenDB.Text = "0.00";
            // 
            // lblReserve
            // 
            this.lblReserve.AutoSize = true;
            this.lblReserve.Location = new System.Drawing.Point(15, 39);
            this.lblReserve.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReserve.Name = "lblReserve";
            this.lblReserve.Size = new System.Drawing.Size(190, 17);
            this.lblReserve.TabIndex = 7;
            this.lblReserve.Text = "Geen reservering gevonden.";
            // 
            // BetalingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 140);
            this.Controls.Add(this.lblReserve);
            this.Controls.Add(this.lblKostenDB);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.lblKosten);
            this.Controls.Add(this.btnBetalen);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BetalingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BetalingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBetalen;
        private System.Windows.Forms.Label lblKosten;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Label lblKostenDB;
        private System.Windows.Forms.Label lblReserve;
    }
}