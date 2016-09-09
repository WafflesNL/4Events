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
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblSaldoDB = new System.Windows.Forms.Label();
            this.btnBetalen = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblKosten = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblKostenDB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(13, 13);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblSaldo.TabIndex = 0;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lblSaldoDB
            // 
            this.lblSaldoDB.AutoSize = true;
            this.lblSaldoDB.Location = new System.Drawing.Point(53, 13);
            this.lblSaldoDB.Name = "lblSaldoDB";
            this.lblSaldoDB.Size = new System.Drawing.Size(28, 13);
            this.lblSaldoDB.TabIndex = 1;
            this.lblSaldoDB.Text = "0.00";
            // 
            // btnBetalen
            // 
            this.btnBetalen.Location = new System.Drawing.Point(220, 92);
            this.btnBetalen.Name = "btnBetalen";
            this.btnBetalen.Size = new System.Drawing.Size(75, 23);
            this.btnBetalen.TabIndex = 2;
            this.btnBetalen.Text = "Betalen";
            this.btnBetalen.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(279, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // lblKosten
            // 
            this.lblKosten.AutoSize = true;
            this.lblKosten.Location = new System.Drawing.Point(13, 75);
            this.lblKosten.Name = "lblKosten";
            this.lblKosten.Size = new System.Drawing.Size(40, 13);
            this.lblKosten.TabIndex = 4;
            this.lblKosten.Text = "Kosten";
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(13, 32);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(35, 13);
            this.lblEvent.TabIndex = 5;
            this.lblEvent.Text = "Event";
            // 
            // lblKostenDB
            // 
            this.lblKostenDB.AutoSize = true;
            this.lblKostenDB.Location = new System.Drawing.Point(53, 75);
            this.lblKostenDB.Name = "lblKostenDB";
            this.lblKostenDB.Size = new System.Drawing.Size(28, 13);
            this.lblKostenDB.TabIndex = 6;
            this.lblKostenDB.Text = "0.00";
            // 
            // BetalingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 126);
            this.Controls.Add(this.lblKostenDB);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.lblKosten);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnBetalen);
            this.Controls.Add(this.lblSaldoDB);
            this.Controls.Add(this.lblSaldo);
            this.Name = "BetalingsForm";
            this.Text = "BetalingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblSaldoDB;
        private System.Windows.Forms.Button btnBetalen;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblKosten;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Label lblKostenDB;
    }
}