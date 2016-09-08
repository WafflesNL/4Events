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
            this.lblVerhuurd = new System.Windows.Forms.Label();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbbMateriaal
            // 
            this.lbbMateriaal.FormattingEnabled = true;
            this.lbbMateriaal.Location = new System.Drawing.Point(12, 41);
            this.lbbMateriaal.Name = "lbbMateriaal";
            this.lbbMateriaal.Size = new System.Drawing.Size(195, 277);
            this.lbbMateriaal.TabIndex = 0;
            // 
            // btnVerhuur
            // 
            this.btnVerhuur.Location = new System.Drawing.Point(213, 39);
            this.btnVerhuur.Name = "btnVerhuur";
            this.btnVerhuur.Size = new System.Drawing.Size(82, 23);
            this.btnVerhuur.TabIndex = 1;
            this.btnVerhuur.Text = "Verhuur";
            this.btnVerhuur.UseVisualStyleBackColor = true;
            // 
            // btnIndex
            // 
            this.btnIndex.Location = new System.Drawing.Point(213, 68);
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
            // lblVerhuurd
            // 
            this.lblVerhuurd.AutoSize = true;
            this.lblVerhuurd.Location = new System.Drawing.Point(65, 22);
            this.lblVerhuurd.Name = "lblVerhuurd";
            this.lblVerhuurd.Size = new System.Drawing.Size(50, 13);
            this.lblVerhuurd.TabIndex = 4;
            this.lblVerhuurd.Text = "Verhuurd";
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(214, 98);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(75, 23);
            this.btnToevoegen.TabIndex = 5;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            // 
            // VerhuurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 330);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.lblVerhuurd);
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
        private System.Windows.Forms.Label lblVerhuurd;
        private System.Windows.Forms.Button btnToevoegen;
    }
}