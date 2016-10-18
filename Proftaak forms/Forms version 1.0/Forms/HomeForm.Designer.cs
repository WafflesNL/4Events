﻿namespace Forms_version_1._0
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
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnReservePlace = new System.Windows.Forms.Button();
            this.btnAccountView = new System.Windows.Forms.Button();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(9, 299);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(68, 36);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnTijdlijn
            // 
            this.btnTijdlijn.Location = new System.Drawing.Point(12, 107);
            this.btnTijdlijn.Name = "btnTijdlijn";
            this.btnTijdlijn.Size = new System.Drawing.Size(129, 28);
            this.btnTijdlijn.TabIndex = 1;
            this.btnTijdlijn.Text = "Naar Tijdlijn";
            this.btnTijdlijn.UseVisualStyleBackColor = true;
            this.btnTijdlijn.Click += new System.EventHandler(this.btnTijdlijn_Click);
            // 
            // cbSelectEvent
            // 
            this.cbSelectEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectEvent.FormattingEnabled = true;
            this.cbSelectEvent.Location = new System.Drawing.Point(12, 17);
            this.cbSelectEvent.Name = "cbSelectEvent";
            this.cbSelectEvent.Size = new System.Drawing.Size(283, 21);
            this.cbSelectEvent.TabIndex = 2;
            this.cbSelectEvent.SelectedIndexChanged += new System.EventHandler(this.cbSelectEvent_SelectedIndexChanged);
            // 
            // btnBetalingStatus
            // 
            this.btnBetalingStatus.Enabled = false;
            this.btnBetalingStatus.Location = new System.Drawing.Point(168, 145);
            this.btnBetalingStatus.Name = "btnBetalingStatus";
            this.btnBetalingStatus.Size = new System.Drawing.Size(129, 28);
            this.btnBetalingStatus.TabIndex = 3;
            this.btnBetalingStatus.Text = "Betalingsstatus";
            this.btnBetalingStatus.UseVisualStyleBackColor = true;
            this.btnBetalingStatus.Click += new System.EventHandler(this.btnBetalingStatus_Click);
            // 
            // btnEventInfo
            // 
            this.btnEventInfo.Enabled = false;
            this.btnEventInfo.Location = new System.Drawing.Point(11, 179);
            this.btnEventInfo.Name = "btnEventInfo";
            this.btnEventInfo.Size = new System.Drawing.Size(129, 28);
            this.btnEventInfo.TabIndex = 4;
            this.btnEventInfo.Text = "Eventinformatie";
            this.btnEventInfo.UseVisualStyleBackColor = true;
            this.btnEventInfo.Click += new System.EventHandler(this.btnEventInfo_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Location = new System.Drawing.Point(170, 299);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(127, 36);
            this.btnAccount.TabIndex = 5;
            this.btnAccount.Text = "Accountinformatie";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Enabled = false;
            this.btnReserve.Location = new System.Drawing.Point(167, 179);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(129, 28);
            this.btnReserve.TabIndex = 6;
            this.btnReserve.Text = "Reserveren";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserveren_Click);
            // 
            // btnReservePlace
            // 
            this.btnReservePlace.Location = new System.Drawing.Point(12, 213);
            this.btnReservePlace.Name = "btnReservePlace";
            this.btnReservePlace.Size = new System.Drawing.Size(129, 28);
            this.btnReservePlace.TabIndex = 7;
            this.btnReservePlace.Text = "Plaats Reserveren";
            this.btnReservePlace.UseVisualStyleBackColor = true;
            this.btnReservePlace.Click += new System.EventHandler(this.btnPlaats_Click);
            // 
            // btnAccountView
            // 
            this.btnAccountView.Location = new System.Drawing.Point(168, 213);
            this.btnAccountView.Name = "btnAccountView";
            this.btnAccountView.Size = new System.Drawing.Size(128, 28);
            this.btnAccountView.TabIndex = 8;
            this.btnAccountView.Text = "Account overzicht";
            this.btnAccountView.UseVisualStyleBackColor = true;
            this.btnAccountView.Visible = false;
            this.btnAccountView.Click += new System.EventHandler(this.btnAccountWijzingen_Click);
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Location = new System.Drawing.Point(12, 141);
            this.btnCreateEvent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(128, 32);
            this.btnCreateEvent.TabIndex = 9;
            this.btnCreateEvent.Text = " Event aanmaken";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 346);
            this.Controls.Add(this.btnCreateEvent);
            this.Controls.Add(this.btnAccountView);
            this.Controls.Add(this.btnReservePlace);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnEventInfo);
            this.Controls.Add(this.btnBetalingStatus);
            this.Controls.Add(this.cbSelectEvent);
            this.Controls.Add(this.btnTijdlijn);
            this.Controls.Add(this.btnLogOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnReservePlace;
        private System.Windows.Forms.Button btnAccountView;
        private System.Windows.Forms.Button btnCreateEvent;
    }
}