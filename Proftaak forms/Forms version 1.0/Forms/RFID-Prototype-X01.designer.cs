namespace RFID_Reader_Prototype_X01
{
    partial class Form1
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbRFIDTag = new System.Windows.Forms.TextBox();
            this.tgRFID = new System.Windows.Forms.Label();
            this.tbWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(13, 226);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open RFID";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(197, 226);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close RFID";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbRFIDTag
            // 
            this.tbRFIDTag.Location = new System.Drawing.Point(53, 12);
            this.tbRFIDTag.Name = "tbRFIDTag";
            this.tbRFIDTag.Size = new System.Drawing.Size(100, 20);
            this.tbRFIDTag.TabIndex = 2;
            // 
            // tgRFID
            // 
            this.tgRFID.AutoSize = true;
            this.tgRFID.Location = new System.Drawing.Point(10, 15);
            this.tgRFID.Name = "tgRFID";
            this.tgRFID.Size = new System.Drawing.Size(32, 13);
            this.tgRFID.TabIndex = 3;
            this.tgRFID.Text = "RFID";
            // 
            // tbWrite
            // 
            this.tbWrite.Location = new System.Drawing.Point(197, 197);
            this.tbWrite.Name = "tbWrite";
            this.tbWrite.Size = new System.Drawing.Size(75, 23);
            this.tbWrite.TabIndex = 4;
            this.tbWrite.Text = "Write";
            this.tbWrite.UseVisualStyleBackColor = true;
            this.tbWrite.Click += new System.EventHandler(this.tbWrite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tbWrite);
            this.Controls.Add(this.tgRFID);
            this.Controls.Add(this.tbRFIDTag);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbRFIDTag;
        private System.Windows.Forms.Label tgRFID;
        private System.Windows.Forms.Button tbWrite;
    }
}

