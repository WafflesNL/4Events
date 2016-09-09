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
            this.lstReservering = new System.Windows.Forms.ListBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblBetalingsstatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.btnTerug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstReservering
            // 
            this.lstReservering.FormattingEnabled = true;
            this.lstReservering.Location = new System.Drawing.Point(12, 32);
            this.lstReservering.Name = "lstReservering";
            this.lstReservering.Size = new System.Drawing.Size(182, 277);
            this.lstReservering.TabIndex = 0;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(13, 13);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(35, 13);
            this.lblNaam.TabIndex = 1;
            this.lblNaam.Text = "Naam";
            // 
            // lblBetalingsstatus
            // 
            this.lblBetalingsstatus.AutoSize = true;
            this.lblBetalingsstatus.Location = new System.Drawing.Point(89, 13);
            this.lblBetalingsstatus.Name = "lblBetalingsstatus";
            this.lblBetalingsstatus.Size = new System.Drawing.Size(78, 13);
            this.lblBetalingsstatus.TabIndex = 2;
            this.lblBetalingsstatus.Text = "Betalingsstatus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(200, 32);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(95, 23);
            this.btnVerwijder.TabIndex = 4;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(12, 315);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(75, 37);
            this.btnTerug.TabIndex = 5;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            // 
            // ReserveringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 358);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBetalingsstatus);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.lstReservering);
            this.Name = "ReserveringForm";
            this.Text = "ReserveringForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstReservering;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblBetalingsstatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Button btnTerug;
    }
}