namespace Forms_version_1._0.Forms
{
    partial class TijdlijnForm
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
            this.TijdlijnBox = new System.Windows.Forms.ListBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.btnLike = new System.Windows.Forms.Button();
            this.lbLikes = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblPost = new System.Windows.Forms.Label();
            this.btnAttach = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbCatergory = new System.Windows.Forms.ComboBox();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.btnTerug = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lblAttach = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TijdlijnBox
            // 
            this.TijdlijnBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.TijdlijnBox.FormattingEnabled = true;
            this.TijdlijnBox.ItemHeight = 14;
            this.TijdlijnBox.Location = new System.Drawing.Point(12, 29);
            this.TijdlijnBox.Name = "TijdlijnBox";
            this.TijdlijnBox.Size = new System.Drawing.Size(912, 438);
            this.TijdlijnBox.TabIndex = 0;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(240, 477);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(78, 33);
            this.btnPost.TabIndex = 1;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(12, 477);
            this.txtPost.Multiline = true;
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(199, 97);
            this.txtPost.TabIndex = 2;
            // 
            // btnLike
            // 
            this.btnLike.Location = new System.Drawing.Point(849, 475);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(75, 23);
            this.btnLike.TabIndex = 3;
            this.btnLike.Text = "Like";
            this.btnLike.UseVisualStyleBackColor = true;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // lbLikes
            // 
            this.lbLikes.AutoSize = true;
            this.lbLikes.Location = new System.Drawing.Point(784, 12);
            this.lbLikes.Name = "lbLikes";
            this.lbLikes.Size = new System.Drawing.Size(32, 13);
            this.lbLikes.TabIndex = 4;
            this.lbLikes.Text = "Likes";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(12, 12);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(35, 13);
            this.lblNaam.TabIndex = 5;
            this.lblNaam.Text = "Naam";
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Location = new System.Drawing.Point(154, 12);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(33, 13);
            this.lblPost.TabIndex = 6;
            this.lblPost.Text = "Posts";
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(217, 478);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(17, 32);
            this.btnAttach.TabIndex = 7;
            this.btnAttach.Text = "A";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(324, 478);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 32);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "Zoeken";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cbCatergory
            // 
            this.cbCatergory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCatergory.FormattingEnabled = true;
            this.cbCatergory.Location = new System.Drawing.Point(73, 580);
            this.cbCatergory.Name = "cbCatergory";
            this.cbCatergory.Size = new System.Drawing.Size(141, 21);
            this.cbCatergory.TabIndex = 9;
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(12, 583);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(52, 13);
            this.lblCategorie.TabIndex = 10;
            this.lblCategorie.Text = "Categorie";
            // 
            // btnTerug
            // 
            this.btnTerug.Location = new System.Drawing.Point(15, 604);
            this.btnTerug.Name = "btnTerug";
            this.btnTerug.Size = new System.Drawing.Size(80, 31);
            this.btnTerug.TabIndex = 11;
            this.btnTerug.Text = "Terug";
            this.btnTerug.UseVisualStyleBackColor = true;
            this.btnTerug.Click += new System.EventHandler(this.btnTerug_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(849, 504);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 12;
            this.btnDownload.Text = "Download ";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lblAttach
            // 
            this.lblAttach.AutoSize = true;
            this.lblAttach.Location = new System.Drawing.Point(863, 12);
            this.lblAttach.Name = "lblAttach";
            this.lblAttach.Size = new System.Drawing.Size(61, 13);
            this.lblAttach.TabIndex = 13;
            this.lblAttach.Text = "Attachment";
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(849, 534);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 14;
            this.btnReport.Text = "Rapporteer";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // TijdlijnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 647);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.lblAttach);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnTerug);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.cbCatergory);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.lblPost);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.lbLikes);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.txtPost);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.TijdlijnBox);
            this.Name = "TijdlijnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TijdlijnForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox TijdlijnBox;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.Label lbLikes;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cbCatergory;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Button btnTerug;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label lblAttach;
        private System.Windows.Forms.Button btnReport;
    }
}