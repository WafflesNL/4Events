namespace Forms_version_1._0
{
    partial class MateriaalBeschikbaarForm
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
            this.lblMatNaam = new System.Windows.Forms.Label();
            this.lbMateriaal = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMatNaam
            // 
            this.lblMatNaam.AutoSize = true;
            this.lblMatNaam.Location = new System.Drawing.Point(9, 6);
            this.lblMatNaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatNaam.Name = "lblMatNaam";
            this.lblMatNaam.Size = new System.Drawing.Size(66, 17);
            this.lblMatNaam.TabIndex = 5;
            this.lblMatNaam.Text = "Materiaal";
            // 
            // lbMateriaal
            // 
            this.lbMateriaal.FormattingEnabled = true;
            this.lbMateriaal.ItemHeight = 16;
            this.lbMateriaal.Location = new System.Drawing.Point(13, 29);
            this.lbMateriaal.Margin = new System.Windows.Forms.Padding(4);
            this.lbMateriaal.Name = "lbMateriaal";
            this.lbMateriaal.Size = new System.Drawing.Size(350, 340);
            this.lbMateriaal.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(370, 29);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(108, 44);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // MateriaalBeschikbaarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 381);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblMatNaam);
            this.Controls.Add(this.lbMateriaal);
            this.Name = "MateriaalBeschikbaarForm";
            this.Text = "MateriaalBeschikbaarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatNaam;
        private System.Windows.Forms.ListBox lbMateriaal;
        private System.Windows.Forms.Button btnRefresh;
    }
}