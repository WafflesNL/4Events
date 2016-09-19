namespace Forms_version_1._0.Forms
{
    partial class Filter
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
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblKernwoord = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.tbKernwoord = new System.Windows.Forms.TextBox();
            this.tbCategorie = new System.Windows.Forms.TextBox();
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnZoek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(12, 9);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(38, 13);
            this.lblNaam.TabIndex = 0;
            this.lblNaam.Text = "Naam:";
            // 
            // lblKernwoord
            // 
            this.lblKernwoord.AutoSize = true;
            this.lblKernwoord.Location = new System.Drawing.Point(12, 34);
            this.lblKernwoord.Name = "lblKernwoord";
            this.lblKernwoord.Size = new System.Drawing.Size(73, 13);
            this.lblKernwoord.TabIndex = 1;
            this.lblKernwoord.Text = "Kernwoorden:";
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(12, 58);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(55, 13);
            this.lblCategorie.TabIndex = 2;
            this.lblCategorie.Text = "Categorie:";
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(99, 6);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(155, 20);
            this.tbNaam.TabIndex = 3;
            // 
            // tbKernwoord
            // 
            this.tbKernwoord.Location = new System.Drawing.Point(99, 31);
            this.tbKernwoord.Name = "tbKernwoord";
            this.tbKernwoord.Size = new System.Drawing.Size(155, 20);
            this.tbKernwoord.TabIndex = 4;
            // 
            // tbCategorie
            // 
            this.tbCategorie.Location = new System.Drawing.Point(99, 55);
            this.tbCategorie.Name = "tbCategorie";
            this.tbCategorie.Size = new System.Drawing.Size(155, 20);
            this.tbCategorie.TabIndex = 5;
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(13, 82);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(75, 23);
            this.btnTerug.TabIndex = 6;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            // 
            // btnZoek
            // 
            this.btnZoek.Location = new System.Drawing.Point(179, 82);
            this.btnZoek.Name = "btnZoek";
            this.btnZoek.Size = new System.Drawing.Size(75, 23);
            this.btnZoek.TabIndex = 7;
            this.btnZoek.Text = "Zoek";
            this.btnZoek.UseVisualStyleBackColor = true;
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 117);
            this.Controls.Add(this.btnZoek);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.tbCategorie);
            this.Controls.Add(this.tbKernwoord);
            this.Controls.Add(this.tbNaam);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.lblKernwoord);
            this.Controls.Add(this.lblNaam);
            this.Name = "Filter";
            this.Text = "Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblKernwoord;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.TextBox tbKernwoord;
        private System.Windows.Forms.TextBox tbCategorie;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnZoek;
    }
}