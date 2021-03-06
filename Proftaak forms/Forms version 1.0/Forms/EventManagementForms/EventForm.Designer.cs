﻿namespace Forms_version_1._0.Forms
{
    partial class EventForm
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
            this.components = new System.ComponentModel.Container();
            this.lblEventNaam = new System.Windows.Forms.Label();
            this.lblEventBeschrijving = new System.Windows.Forms.Label();
            this.tbEventName = new System.Windows.Forms.TextBox();
            this.tbEventDescription = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblEventInfo = new System.Windows.Forms.Label();
            this.lblEventLocatie = new System.Windows.Forms.Label();
            this.lblEventDatum = new System.Windows.Forms.Label();
            this.dtpDateEvent = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnQuestOverview = new System.Windows.Forms.Button();
            this.btnReservations = new System.Windows.Forms.Button();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.btnRental = new System.Windows.Forms.Button();
            this.numQuantityVisitors = new System.Windows.Forms.NumericUpDown();
            this.lblQuantityVisitors = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityVisitors)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEventNaam
            // 
            this.lblEventNaam.AutoSize = true;
            this.lblEventNaam.Location = new System.Drawing.Point(12, 57);
            this.lblEventNaam.Name = "lblEventNaam";
            this.lblEventNaam.Size = new System.Drawing.Size(61, 13);
            this.lblEventNaam.TabIndex = 0;
            this.lblEventNaam.Text = "Eventnaam";
            // 
            // lblEventBeschrijving
            // 
            this.lblEventBeschrijving.AutoSize = true;
            this.lblEventBeschrijving.Location = new System.Drawing.Point(12, 83);
            this.lblEventBeschrijving.Name = "lblEventBeschrijving";
            this.lblEventBeschrijving.Size = new System.Drawing.Size(95, 13);
            this.lblEventBeschrijving.TabIndex = 1;
            this.lblEventBeschrijving.Text = "Event Beschrijving";
            // 
            // tbEventName
            // 
            this.tbEventName.Location = new System.Drawing.Point(136, 54);
            this.tbEventName.Name = "tbEventName";
            this.tbEventName.Size = new System.Drawing.Size(159, 20);
            this.tbEventName.TabIndex = 2;
            // 
            // tbEventDescription
            // 
            this.tbEventDescription.Location = new System.Drawing.Point(136, 80);
            this.tbEventDescription.Multiline = true;
            this.tbEventDescription.Name = "tbEventDescription";
            this.tbEventDescription.Size = new System.Drawing.Size(159, 71);
            this.tbEventDescription.TabIndex = 3;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // lblEventInfo
            // 
            this.lblEventInfo.AutoSize = true;
            this.lblEventInfo.Location = new System.Drawing.Point(95, 9);
            this.lblEventInfo.Name = "lblEventInfo";
            this.lblEventInfo.Size = new System.Drawing.Size(84, 13);
            this.lblEventInfo.TabIndex = 4;
            this.lblEventInfo.Text = "Event Informatie";
            // 
            // lblEventLocatie
            // 
            this.lblEventLocatie.AutoSize = true;
            this.lblEventLocatie.Location = new System.Drawing.Point(12, 162);
            this.lblEventLocatie.Name = "lblEventLocatie";
            this.lblEventLocatie.Size = new System.Drawing.Size(107, 13);
            this.lblEventLocatie.TabIndex = 5;
            this.lblEventLocatie.Text = "Locatie (dorp of stad)";
            // 
            // lblEventDatum
            // 
            this.lblEventDatum.AutoSize = true;
            this.lblEventDatum.Location = new System.Drawing.Point(12, 186);
            this.lblEventDatum.Name = "lblEventDatum";
            this.lblEventDatum.Size = new System.Drawing.Size(69, 13);
            this.lblEventDatum.TabIndex = 7;
            this.lblEventDatum.Text = "Event Datum";
            // 
            // dtpDateEvent
            // 
            this.dtpDateEvent.Enabled = false;
            this.dtpDateEvent.Location = new System.Drawing.Point(136, 182);
            this.dtpDateEvent.Name = "dtpDateEvent";
            this.dtpDateEvent.Size = new System.Drawing.Size(159, 20);
            this.dtpDateEvent.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(9, 284);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 43);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Opslaan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // btnQuestOverview
            // 
            this.btnQuestOverview.Location = new System.Drawing.Point(151, 269);
            this.btnQuestOverview.Name = "btnQuestOverview";
            this.btnQuestOverview.Size = new System.Drawing.Size(146, 25);
            this.btnQuestOverview.TabIndex = 11;
            this.btnQuestOverview.Text = "Aanwezige bezoekers";
            this.btnQuestOverview.UseVisualStyleBackColor = true;
            this.btnQuestOverview.Click += new System.EventHandler(this.btnOverzicht_Click);
            // 
            // btnReservations
            // 
            this.btnReservations.Location = new System.Drawing.Point(151, 301);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(146, 25);
            this.btnReservations.TabIndex = 12;
            this.btnReservations.Text = "Reserveringen";
            this.btnReservations.UseVisualStyleBackColor = true;
            this.btnReservations.Click += new System.EventHandler(this.btnReservering_Click);
            // 
            // cbLocation
            // 
            this.cbLocation.Enabled = false;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Items.AddRange(new object[] {
            "Tilburg",
            "Eindhoven",
            "Amsterdam",
            "Denhaag"});
            this.cbLocation.Location = new System.Drawing.Point(136, 156);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(159, 21);
            this.cbLocation.TabIndex = 13;
            // 
            // btnRental
            // 
            this.btnRental.Location = new System.Drawing.Point(151, 236);
            this.btnRental.Name = "btnRental";
            this.btnRental.Size = new System.Drawing.Size(146, 25);
            this.btnRental.TabIndex = 14;
            this.btnRental.Text = "Verhuur";
            this.btnRental.UseVisualStyleBackColor = true;
            this.btnRental.Click += new System.EventHandler(this.btnVerhuur_Click);
            // 
            // numQuantityVisitors
            // 
            this.numQuantityVisitors.Location = new System.Drawing.Point(136, 206);
            this.numQuantityVisitors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numQuantityVisitors.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numQuantityVisitors.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numQuantityVisitors.Name = "numQuantityVisitors";
            this.numQuantityVisitors.Size = new System.Drawing.Size(158, 20);
            this.numQuantityVisitors.TabIndex = 15;
            this.numQuantityVisitors.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblQuantityVisitors
            // 
            this.lblQuantityVisitors.AutoSize = true;
            this.lblQuantityVisitors.Location = new System.Drawing.Point(12, 210);
            this.lblQuantityVisitors.Name = "lblQuantityVisitors";
            this.lblQuantityVisitors.Size = new System.Drawing.Size(83, 13);
            this.lblQuantityVisitors.TabIndex = 16;
            this.lblQuantityVisitors.Text = "Max. Bezoekers";
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 339);
            this.Controls.Add(this.lblQuantityVisitors);
            this.Controls.Add(this.numQuantityVisitors);
            this.Controls.Add(this.btnRental);
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(this.btnReservations);
            this.Controls.Add(this.btnQuestOverview);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpDateEvent);
            this.Controls.Add(this.lblEventDatum);
            this.Controls.Add(this.lblEventLocatie);
            this.Controls.Add(this.lblEventInfo);
            this.Controls.Add(this.tbEventDescription);
            this.Controls.Add(this.tbEventName);
            this.Controls.Add(this.lblEventBeschrijving);
            this.Controls.Add(this.lblEventNaam);
            this.Name = "EventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventForm";
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityVisitors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEventNaam;
        private System.Windows.Forms.Label lblEventBeschrijving;
        private System.Windows.Forms.TextBox tbEventName;
        private System.Windows.Forms.TextBox tbEventDescription;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lblEventInfo;
        private System.Windows.Forms.Label lblEventLocatie;
        private System.Windows.Forms.Label lblEventDatum;
        private System.Windows.Forms.DateTimePicker dtpDateEvent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnQuestOverview;
        private System.Windows.Forms.Button btnReservations;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.Button btnRental;
        private System.Windows.Forms.NumericUpDown numQuantityVisitors;
        private System.Windows.Forms.Label lblQuantityVisitors;
    }
}