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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLike = new System.Windows.Forms.Button();
            this.lbLikes = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblPost = new System.Windows.Forms.Label();
            this.btnAttach = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TijdlijnBox
            // 
            this.TijdlijnBox.FormattingEnabled = true;
            this.TijdlijnBox.Location = new System.Drawing.Point(9, 28);
            this.TijdlijnBox.Name = "TijdlijnBox";
            this.TijdlijnBox.Size = new System.Drawing.Size(310, 290);
            this.TijdlijnBox.TabIndex = 0;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(241, 324);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(78, 33);
            this.btnPost.TabIndex = 1;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 324);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 33);
            this.textBox1.TabIndex = 2;
            // 
            // btnLike
            // 
            this.btnLike.Location = new System.Drawing.Point(325, 28);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(75, 23);
            this.btnLike.TabIndex = 3;
            this.btnLike.Text = "Like";
            this.btnLike.UseVisualStyleBackColor = true;
            // 
            // lbLikes
            // 
            this.lbLikes.AutoSize = true;
            this.lbLikes.Location = new System.Drawing.Point(287, 12);
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
            this.lblPost.Location = new System.Drawing.Point(101, 12);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(33, 13);
            this.lblPost.TabIndex = 6;
            this.lblPost.Text = "Posts";
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(218, 324);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(17, 32);
            this.btnAttach.TabIndex = 7;
            this.btnAttach.Text = "A";
            this.btnAttach.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(325, 324);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 32);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "Zoeken";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(70, 363);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(12, 366);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(52, 13);
            this.lblCategorie.TabIndex = 10;
            this.lblCategorie.Text = "Categorie";
            // 
            // TijdlijnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 394);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.lblPost);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.lbLikes);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.TijdlijnBox);
            this.Name = "TijdlijnForm";
            this.Text = "TijdlijnForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox TijdlijnBox;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.Label lbLikes;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblCategorie;
    }
}