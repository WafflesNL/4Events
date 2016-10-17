namespace Forms_version_1._0.Forms
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
            this.tbEventDiscription = new System.Windows.Forms.TextBox();
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
            this.lblEventNaam.Location = new System.Drawing.Point(16, 70);
            this.lblEventNaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventNaam.Name = "lblEventNaam";
            this.lblEventNaam.Size = new System.Drawing.Size(79, 17);
            this.lblEventNaam.TabIndex = 0;
            this.lblEventNaam.Text = "Eventnaam";
            // 
            // lblEventBeschrijving
            // 
            this.lblEventBeschrijving.AutoSize = true;
            this.lblEventBeschrijving.Location = new System.Drawing.Point(16, 102);
            this.lblEventBeschrijving.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventBeschrijving.Name = "lblEventBeschrijving";
            this.lblEventBeschrijving.Size = new System.Drawing.Size(124, 17);
            this.lblEventBeschrijving.TabIndex = 1;
            this.lblEventBeschrijving.Text = "Event Beschrijving";
            // 
            // tbEventName
            // 
            this.tbEventName.Location = new System.Drawing.Point(199, 66);
            this.tbEventName.Margin = new System.Windows.Forms.Padding(4);
            this.tbEventName.Name = "tbEventName";
            this.tbEventName.Size = new System.Drawing.Size(193, 22);
            this.tbEventName.TabIndex = 2;
            // 
            // tbEventDiscription
            // 
            this.tbEventDiscription.Location = new System.Drawing.Point(199, 98);
            this.tbEventDiscription.Margin = new System.Windows.Forms.Padding(4);
            this.tbEventDiscription.Multiline = true;
            this.tbEventDiscription.Name = "tbEventDiscription";
            this.tbEventDiscription.Size = new System.Drawing.Size(193, 86);
            this.tbEventDiscription.TabIndex = 3;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // lblEventInfo
            // 
            this.lblEventInfo.AutoSize = true;
            this.lblEventInfo.Location = new System.Drawing.Point(127, 11);
            this.lblEventInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventInfo.Name = "lblEventInfo";
            this.lblEventInfo.Size = new System.Drawing.Size(110, 17);
            this.lblEventInfo.TabIndex = 4;
            this.lblEventInfo.Text = "Event Informatie";
            // 
            // lblEventLocatie
            // 
            this.lblEventLocatie.AutoSize = true;
            this.lblEventLocatie.Location = new System.Drawing.Point(16, 199);
            this.lblEventLocatie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventLocatie.Name = "lblEventLocatie";
            this.lblEventLocatie.Size = new System.Drawing.Size(144, 17);
            this.lblEventLocatie.TabIndex = 5;
            this.lblEventLocatie.Text = "Locatie (dorp of stad)";
            // 
            // lblEventDatum
            // 
            this.lblEventDatum.AutoSize = true;
            this.lblEventDatum.Location = new System.Drawing.Point(16, 229);
            this.lblEventDatum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventDatum.Name = "lblEventDatum";
            this.lblEventDatum.Size = new System.Drawing.Size(89, 17);
            this.lblEventDatum.TabIndex = 7;
            this.lblEventDatum.Text = "Event Datum";
            // 
            // dtpDateEvent
            // 
            this.dtpDateEvent.Location = new System.Drawing.Point(199, 224);
            this.dtpDateEvent.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateEvent.Name = "dtpDateEvent";
            this.dtpDateEvent.Size = new System.Drawing.Size(193, 22);
            this.dtpDateEvent.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 350);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 53);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Opslaan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // btnQuestOverview
            // 
            this.btnQuestOverview.Location = new System.Drawing.Point(201, 331);
            this.btnQuestOverview.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuestOverview.Name = "btnQuestOverview";
            this.btnQuestOverview.Size = new System.Drawing.Size(195, 31);
            this.btnQuestOverview.TabIndex = 11;
            this.btnQuestOverview.Text = "Aanwezige bezoekers";
            this.btnQuestOverview.UseVisualStyleBackColor = true;
            this.btnQuestOverview.Click += new System.EventHandler(this.btnOverzicht_Click);
            // 
            // btnReservations
            // 
            this.btnReservations.Location = new System.Drawing.Point(201, 370);
            this.btnReservations.Margin = new System.Windows.Forms.Padding(4);
            this.btnReservations.Name = "btnReservations";
            this.btnReservations.Size = new System.Drawing.Size(195, 31);
            this.btnReservations.TabIndex = 12;
            this.btnReservations.Text = "Reserveringen";
            this.btnReservations.UseVisualStyleBackColor = true;
            this.btnReservations.Click += new System.EventHandler(this.btnReservering_Click);
            // 
            // cbLocation
            // 
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Items.AddRange(new object[] {
            "Tilburg",
            "Eindhoven",
            "Amsterdam",
            "Denhaag"});
            this.cbLocation.Location = new System.Drawing.Point(199, 192);
            this.cbLocation.Margin = new System.Windows.Forms.Padding(4);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(193, 24);
            this.cbLocation.TabIndex = 13;
            // 
            // btnRental
            // 
            this.btnRental.Location = new System.Drawing.Point(201, 290);
            this.btnRental.Margin = new System.Windows.Forms.Padding(4);
            this.btnRental.Name = "btnRental";
            this.btnRental.Size = new System.Drawing.Size(195, 31);
            this.btnRental.TabIndex = 14;
            this.btnRental.Text = "Verhuur";
            this.btnRental.UseVisualStyleBackColor = true;
            this.btnRental.Click += new System.EventHandler(this.btnVerhuur_Click);
            // 
            // numQuantityVisitors
            // 
            this.numQuantityVisitors.Location = new System.Drawing.Point(199, 253);
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
            this.numQuantityVisitors.Size = new System.Drawing.Size(193, 22);
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
            this.lblQuantityVisitors.Location = new System.Drawing.Point(16, 258);
            this.lblQuantityVisitors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantityVisitors.Name = "lblQuantityVisitors";
            this.lblQuantityVisitors.Size = new System.Drawing.Size(108, 17);
            this.lblQuantityVisitors.TabIndex = 16;
            this.lblQuantityVisitors.Text = "Max. Bezoekers";
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 417);
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
            this.Controls.Add(this.tbEventDiscription);
            this.Controls.Add(this.tbEventName);
            this.Controls.Add(this.lblEventBeschrijving);
            this.Controls.Add(this.lblEventNaam);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox tbEventDiscription;
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