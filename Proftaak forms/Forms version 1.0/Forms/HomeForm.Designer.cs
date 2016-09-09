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
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(9, 334);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(68, 36);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnTijdlijn
            // 
            this.btnTijdlijn.Location = new System.Drawing.Point(12, 46);
            this.btnTijdlijn.Name = "btnTijdlijn";
            this.btnTijdlijn.Size = new System.Drawing.Size(129, 28);
            this.btnTijdlijn.TabIndex = 1;
            this.btnTijdlijn.Text = "Naar Tijdlijn";
            this.btnTijdlijn.UseVisualStyleBackColor = true;
            // 
            // cbSelectEvent
            // 
            this.cbSelectEvent.FormattingEnabled = true;
            this.cbSelectEvent.Location = new System.Drawing.Point(12, 17);
            this.cbSelectEvent.Name = "cbSelectEvent";
            this.cbSelectEvent.Size = new System.Drawing.Size(283, 21);
            this.cbSelectEvent.TabIndex = 2;
            // 
            // btnBetalingStatus
            // 
            this.btnBetalingStatus.Location = new System.Drawing.Point(166, 46);
            this.btnBetalingStatus.Name = "btnBetalingStatus";
            this.btnBetalingStatus.Size = new System.Drawing.Size(129, 28);
            this.btnBetalingStatus.TabIndex = 3;
            this.btnBetalingStatus.Text = "Betalingsstatus";
            this.btnBetalingStatus.UseVisualStyleBackColor = true;
            // 
            // btnEventInfo
            // 
            this.btnEventInfo.Location = new System.Drawing.Point(12, 92);
            this.btnEventInfo.Name = "btnEventInfo";
            this.btnEventInfo.Size = new System.Drawing.Size(129, 28);
            this.btnEventInfo.TabIndex = 4;
            this.btnEventInfo.Text = "Eventinformatie";
            this.btnEventInfo.UseVisualStyleBackColor = true;
            // 
            // btnAccount
            // 
            this.btnAccount.Location = new System.Drawing.Point(166, 334);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(129, 36);
            this.btnAccount.TabIndex = 5;
            this.btnAccount.Text = "Accountinformatie";
            this.btnAccount.UseVisualStyleBackColor = true;
            // 
            // btnReserveren
            // 
            this.btnReserveren.Location = new System.Drawing.Point(166, 92);
            this.btnReserveren.Name = "btnReserveren";
            this.btnReserveren.Size = new System.Drawing.Size(129, 28);
            this.btnReserveren.TabIndex = 6;
            this.btnReserveren.Text = "Reserveren";
            this.btnReserveren.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 379);
            this.Controls.Add(this.btnReserveren);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnEventInfo);
            this.Controls.Add(this.btnBetalingStatus);
            this.Controls.Add(this.cbSelectEvent);
            this.Controls.Add(this.btnTijdlijn);
            this.Controls.Add(this.btnLogOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomeForm";
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
    }
}