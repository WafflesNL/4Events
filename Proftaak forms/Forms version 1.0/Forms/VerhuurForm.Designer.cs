namespace Forms_version_1._0.Forms
{
    partial class VerhuurForm
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
            this.lbbMateriaal = new System.Windows.Forms.ListBox();
            this.btnVerhuur = new System.Windows.Forms.Button();
            this.btnIndex = new System.Windows.Forms.Button();
            this.lblMatNaam = new System.Windows.Forms.Label();
            this.lblAantal = new System.Windows.Forms.Label();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.lblPrijs = new System.Windows.Forms.Label();
            this.tbTotaal = new System.Windows.Forms.TextBox();
            this.btnTotaal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbbMateriaal
            // 
            this.lbbMateriaal.FormattingEnabled = true;
            this.lbbMateriaal.Location = new System.Drawing.Point(12, 41);
            this.lbbMateriaal.Name = "lbbMateriaal";
            this.lbbMateriaal.Size = new System.Drawing.Size(189, 277);
            this.lbbMateriaal.TabIndex = 0;
            // 
            // btnVerhuur
            // 
            this.btnVerhuur.Location = new System.Drawing.Point(208, 40);
            this.btnVerhuur.Name = "btnVerhuur";
            this.btnVerhuur.Size = new System.Drawing.Size(82, 23);
            this.btnVerhuur.TabIndex = 1;
            this.btnVerhuur.Text = "Verhuur";
            this.btnVerhuur.UseVisualStyleBackColor = true;
            // 
            // btnIndex
            // 
            this.btnIndex.Location = new System.Drawing.Point(208, 69);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(82, 23);
            this.btnIndex.TabIndex = 2;
            this.btnIndex.Text = "Terug";
            this.btnIndex.UseVisualStyleBackColor = true;
            // 
            // lblMatNaam
            // 
            this.lblMatNaam.AutoSize = true;
            this.lblMatNaam.Location = new System.Drawing.Point(9, 22);
            this.lblMatNaam.Name = "lblMatNaam";
            this.lblMatNaam.Size = new System.Drawing.Size(50, 13);
            this.lblMatNaam.TabIndex = 3;
            this.lblMatNaam.Text = "Materiaal";
            // 
            // lblAantal
            // 
            this.lblAantal.AutoSize = true;
            this.lblAantal.Location = new System.Drawing.Point(132, 22);
            this.lblAantal.Name = "lblAantal";
            this.lblAantal.Size = new System.Drawing.Size(37, 13);
            this.lblAantal.TabIndex = 4;
            this.lblAantal.Text = "Aantal";
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(208, 98);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(81, 23);
            this.btnToevoegen.TabIndex = 5;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            // 
            // lblPrijs
            // 
            this.lblPrijs.AutoSize = true;
            this.lblPrijs.Location = new System.Drawing.Point(175, 22);
            this.lblPrijs.Name = "lblPrijs";
            this.lblPrijs.Size = new System.Drawing.Size(26, 13);
            this.lblPrijs.TabIndex = 6;
            this.lblPrijs.Text = "Prijs";
            // 
            // tbTotaal
            // 
            this.tbTotaal.Location = new System.Drawing.Point(207, 298);
            this.tbTotaal.Name = "tbTotaal";
            this.tbTotaal.Size = new System.Drawing.Size(83, 20);
            this.tbTotaal.TabIndex = 7;
            // 
            // btnTotaal
            // 
            this.btnTotaal.Location = new System.Drawing.Point(208, 269);
            this.btnTotaal.Name = "btnTotaal";
            this.btnTotaal.Size = new System.Drawing.Size(82, 23);
            this.btnTotaal.TabIndex = 8;
            this.btnTotaal.Text = "Totaal";
            this.btnTotaal.UseVisualStyleBackColor = true;
            // 
            // VerhuurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 330);
            this.Controls.Add(this.btnTotaal);
            this.Controls.Add(this.tbTotaal);
            this.Controls.Add(this.lblPrijs);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.lblAantal);
            this.Controls.Add(this.lblMatNaam);
            this.Controls.Add(this.btnIndex);
            this.Controls.Add(this.btnVerhuur);
            this.Controls.Add(this.lbbMateriaal);
            this.Name = "VerhuurForm";
            this.Text = "VerhuurForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbbMateriaal;
        private System.Windows.Forms.Button btnVerhuur;
        private System.Windows.Forms.Button btnIndex;
        private System.Windows.Forms.Label lblMatNaam;
        private System.Windows.Forms.Label lblAantal;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Label lblPrijs;
        private System.Windows.Forms.TextBox tbTotaal;
        private System.Windows.Forms.Button btnTotaal;
    }
}