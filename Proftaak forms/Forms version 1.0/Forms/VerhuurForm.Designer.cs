﻿namespace Forms_version_1._0.Forms
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
            this.lbMateriaal = new System.Windows.Forms.ListBox();
            this.btnVerhuur = new System.Windows.Forms.Button();
            this.btnIndex = new System.Windows.Forms.Button();
            this.lblMatNaam = new System.Windows.Forms.Label();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.tbTotaal = new System.Windows.Forms.TextBox();
            this.btnTotaal = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbSelected = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbMateriaal
            // 
            this.lbMateriaal.FormattingEnabled = true;
            this.lbMateriaal.Location = new System.Drawing.Point(12, 41);
            this.lbMateriaal.Name = "lbMateriaal";
            this.lbMateriaal.Size = new System.Drawing.Size(189, 277);
            this.lbMateriaal.TabIndex = 0;
            // 
            // btnVerhuur
            // 
            this.btnVerhuur.Location = new System.Drawing.Point(220, 40);
            this.btnVerhuur.Name = "btnVerhuur";
            this.btnVerhuur.Size = new System.Drawing.Size(82, 23);
            this.btnVerhuur.TabIndex = 1;
            this.btnVerhuur.Text = "Verhuur";
            this.btnVerhuur.UseVisualStyleBackColor = true;
            this.btnVerhuur.Click += new System.EventHandler(this.btnVerhuur_Click);
            // 
            // btnIndex
            // 
            this.btnIndex.Location = new System.Drawing.Point(12, 324);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(82, 23);
            this.btnIndex.TabIndex = 2;
            this.btnIndex.Text = "Terug";
            this.btnIndex.UseVisualStyleBackColor = true;
            this.btnIndex.Click += new System.EventHandler(this.btnIndex_Click);
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
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(221, 69);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(81, 23);
            this.btnToevoegen.TabIndex = 5;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // tbTotaal
            // 
            this.tbTotaal.Location = new System.Drawing.Point(221, 297);
            this.tbTotaal.Name = "tbTotaal";
            this.tbTotaal.Size = new System.Drawing.Size(83, 20);
            this.tbTotaal.TabIndex = 7;
            // 
            // btnTotaal
            // 
            this.btnTotaal.Location = new System.Drawing.Point(221, 268);
            this.btnTotaal.Name = "btnTotaal";
            this.btnTotaal.Size = new System.Drawing.Size(82, 23);
            this.btnTotaal.TabIndex = 8;
            this.btnTotaal.Text = "Totaal";
            this.btnTotaal.UseVisualStyleBackColor = true;
            this.btnTotaal.Click += new System.EventHandler(this.btnTotaal_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(221, 98);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(81, 23);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lbSelected
            // 
            this.lbSelected.FormattingEnabled = true;
            this.lbSelected.Location = new System.Drawing.Point(329, 40);
            this.lbSelected.Name = "lbSelected";
            this.lbSelected.Size = new System.Drawing.Size(189, 277);
            this.lbSelected.TabIndex = 10;
            // 
            // VerhuurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 351);
            this.Controls.Add(this.lbSelected);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnTotaal);
            this.Controls.Add(this.tbTotaal);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.lblMatNaam);
            this.Controls.Add(this.btnIndex);
            this.Controls.Add(this.btnVerhuur);
            this.Controls.Add(this.lbMateriaal);
            this.Name = "VerhuurForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerhuurForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMateriaal;
        private System.Windows.Forms.Button btnVerhuur;
        private System.Windows.Forms.Button btnIndex;
        private System.Windows.Forms.Label lblMatNaam;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.TextBox tbTotaal;
        private System.Windows.Forms.Button btnTotaal;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListBox lbSelected;
    }
}