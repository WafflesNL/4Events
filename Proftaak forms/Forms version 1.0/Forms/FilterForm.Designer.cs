namespace Forms_version_1._0.Forms
{
    partial class FilterForm
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
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.tbWoord = new System.Windows.Forms.TextBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblWoord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnZoek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(62, 13);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(210, 20);
            this.tbNaam.TabIndex = 0;
            // 
            // tbWoord
            // 
            this.tbWoord.Location = new System.Drawing.Point(62, 39);
            this.tbWoord.Name = "tbWoord";
            this.tbWoord.Size = new System.Drawing.Size(210, 20);
            this.tbWoord.TabIndex = 1;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(12, 16);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(35, 13);
            this.lblNaam.TabIndex = 2;
            this.lblNaam.Text = "Naam";
            // 
            // lblWoord
            // 
            this.lblWoord.AutoSize = true;
            this.lblWoord.Location = new System.Drawing.Point(12, 42);
            this.lblWoord.Name = "lblWoord";
            this.lblWoord.Size = new System.Drawing.Size(39, 13);
            this.lblWoord.TabIndex = 3;
            this.lblWoord.Text = "Woord";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Categorie";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // btnZoek
            // 
            this.btnZoek.Location = new System.Drawing.Point(197, 92);
            this.btnZoek.Name = "btnZoek";
            this.btnZoek.Size = new System.Drawing.Size(75, 23);
            this.btnZoek.TabIndex = 6;
            this.btnZoek.Text = "Zoek";
            this.btnZoek.UseVisualStyleBackColor = true;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.btnZoek);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWoord);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.tbWoord);
            this.Controls.Add(this.tbNaam);
            this.Name = "FilterForm";
            this.Text = "FilterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.TextBox tbWoord;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblWoord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnZoek;
    }
}