namespace Forms_version_1._0
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnTijdlijn = new System.Windows.Forms.Button();
            this.cbSelectEvent = new System.Windows.Forms.ComboBox();
            this.btnBetalingStatus = new System.Windows.Forms.Button();
            this.btnEventInfo = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnReserveren = new System.Windows.Forms.Button();
            this.btnPlaats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(12, 411);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(91, 44);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnTijdlijn
            // 
            this.btnTijdlijn.Location = new System.Drawing.Point(16, 210);
            this.btnTijdlijn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTijdlijn.Name = "btnTijdlijn";
            this.btnTijdlijn.Size = new System.Drawing.Size(172, 34);
            this.btnTijdlijn.TabIndex = 1;
            this.btnTijdlijn.Text = "Naar Tijdlijn";
            this.btnTijdlijn.UseVisualStyleBackColor = true;
            this.btnTijdlijn.Click += new System.EventHandler(this.btnTijdlijn_Click);
            // 
            // cbSelectEvent
            // 
            this.cbSelectEvent.FormattingEnabled = true;
            this.cbSelectEvent.Location = new System.Drawing.Point(16, 21);
            this.cbSelectEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSelectEvent.Name = "cbSelectEvent";
            this.cbSelectEvent.Size = new System.Drawing.Size(376, 24);
            this.cbSelectEvent.TabIndex = 2;
            // 
            // btnBetalingStatus
            // 
            this.btnBetalingStatus.Location = new System.Drawing.Point(221, 210);
            this.btnBetalingStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBetalingStatus.Name = "btnBetalingStatus";
            this.btnBetalingStatus.Size = new System.Drawing.Size(172, 34);
            this.btnBetalingStatus.TabIndex = 3;
            this.btnBetalingStatus.Text = "Betalingsstatus";
            this.btnBetalingStatus.UseVisualStyleBackColor = true;
            this.btnBetalingStatus.Click += new System.EventHandler(this.btnBetalingStatus_Click);
            // 
            // btnEventInfo
            // 
            this.btnEventInfo.Location = new System.Drawing.Point(16, 266);
            this.btnEventInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEventInfo.Name = "btnEventInfo";
            this.btnEventInfo.Size = new System.Drawing.Size(172, 34);
            this.btnEventInfo.TabIndex = 4;
            this.btnEventInfo.Text = "Eventinformatie";
            this.btnEventInfo.UseVisualStyleBackColor = true;
            this.btnEventInfo.Click += new System.EventHandler(this.btnEventInfo_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Location = new System.Drawing.Point(221, 411);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(172, 44);
            this.btnAccount.TabIndex = 5;
            this.btnAccount.Text = "Accountinformatie";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnReserveren
            // 
            this.btnReserveren.Location = new System.Drawing.Point(221, 266);
            this.btnReserveren.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReserveren.Name = "btnReserveren";
            this.btnReserveren.Size = new System.Drawing.Size(172, 34);
            this.btnReserveren.TabIndex = 6;
            this.btnReserveren.Text = "Reserveren";
            this.btnReserveren.UseVisualStyleBackColor = true;
            this.btnReserveren.Click += new System.EventHandler(this.btnReserveren_Click);
            // 
            // btnPlaats
            // 
            this.btnPlaats.Location = new System.Drawing.Point(16, 323);
            this.btnPlaats.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlaats.Name = "btnPlaats";
            this.btnPlaats.Size = new System.Drawing.Size(172, 34);
            this.btnPlaats.TabIndex = 7;
            this.btnPlaats.Text = "Plaats Reserveren";
            this.btnPlaats.UseVisualStyleBackColor = true;
            this.btnPlaats.Click += new System.EventHandler(this.btnPlaats_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 466);
            this.Controls.Add(this.btnPlaats);
            this.Controls.Add(this.btnReserveren);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnEventInfo);
            this.Controls.Add(this.btnBetalingStatus);
            this.Controls.Add(this.cbSelectEvent);
            this.Controls.Add(this.btnTijdlijn);
            this.Controls.Add(this.btnLogOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnTijdlijn;
        private System.Windows.Forms.ComboBox cbSelectEvent;
        private System.Windows.Forms.Button btnBetalingStatus;
        private System.Windows.Forms.Button btnEventInfo;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnReserveren;
        private System.Windows.Forms.Button btnPlaats;
    }
}