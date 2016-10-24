namespace Forms_version_1._0.Forms
{
    partial class OverzichtReserveringForm
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
            this.SuspendLayout();
            // 
            // lstReservering
            // 
            this.lstReservering.FormattingEnabled = true;
            this.lstReservering.ItemHeight = 16;
            this.lstReservering.Location = new System.Drawing.Point(16, 39);
            this.lstReservering.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstReservering.Name = "lstReservering";
            this.lstReservering.Size = new System.Drawing.Size(369, 340);
            this.lstReservering.TabIndex = 0;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(17, 16);
            this.lblNaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(45, 17);
            this.lblNaam.TabIndex = 1;
            this.lblNaam.Text = "Naam";
            // 
            // lblBetalingsstatus
            // 
            this.lblBetalingsstatus.AutoSize = true;
            this.lblBetalingsstatus.Location = new System.Drawing.Point(119, 16);
            this.lblBetalingsstatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBetalingsstatus.Name = "lblBetalingsstatus";
            this.lblBetalingsstatus.Size = new System.Drawing.Size(104, 17);
            this.lblBetalingsstatus.TabIndex = 2;
            this.lblBetalingsstatus.Text = "Betalingsstatus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 3;
            // 
            // OverzichtReserveringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 396);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBetalingsstatus);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.lstReservering);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OverzichtReserveringForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Overzicht Reserveringen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstReservering;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblBetalingsstatus;
        private System.Windows.Forms.Label label1;
    }
}