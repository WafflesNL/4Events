﻿namespace Forms_version_1._0.Forms
{
    partial class InleverForm
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
            this.btnInleveren = new System.Windows.Forms.Button();
            this.lblMatNaam = new System.Windows.Forms.Label();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.tbTotaal = new System.Windows.Forms.TextBox();
            this.btnTotaal = new System.Windows.Forms.Button();
            this.lbSelected = new System.Windows.Forms.ListBox();
            this.lblEvent = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
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
            // btnInleveren
            // 
            this.btnInleveren.Location = new System.Drawing.Point(435, 323);
            this.btnInleveren.Name = "btnInleveren";
            this.btnInleveren.Size = new System.Drawing.Size(82, 23);
            this.btnInleveren.TabIndex = 1;
            this.btnInleveren.Text = "Lever In";
            this.btnInleveren.UseVisualStyleBackColor = true;
            this.btnInleveren.Click += new System.EventHandler(this.btnInleveren_Click);
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
            this.btnToevoegen.Location = new System.Drawing.Point(223, 69);
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
            // lbSelected
            // 
            this.lbSelected.FormattingEnabled = true;
            this.lbSelected.Location = new System.Drawing.Point(329, 40);
            this.lbSelected.Name = "lbSelected";
            this.lbSelected.Size = new System.Drawing.Size(189, 277);
            this.lbSelected.TabIndex = 10;
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(326, 24);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(0, 13);
            this.lblEvent.TabIndex = 11;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(223, 98);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(81, 23);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Verwijderen";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(272, 324);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(145, 23);
            this.btnCheck.TabIndex = 14;
            this.btnCheck.Text = "Check Materiaal Account";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // InleverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 351);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.lbSelected);
            this.Controls.Add(this.btnTotaal);
            this.Controls.Add(this.tbTotaal);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.lblMatNaam);
            this.Controls.Add(this.btnInleveren);
            this.Controls.Add(this.lbMateriaal);
            this.Name = "InleverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerhuurForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClose);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMateriaal;
        private System.Windows.Forms.Button btnInleveren;
        private System.Windows.Forms.Label lblMatNaam;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.TextBox tbTotaal;
        private System.Windows.Forms.Button btnTotaal;
        private System.Windows.Forms.ListBox lbSelected;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCheck;
    }
}