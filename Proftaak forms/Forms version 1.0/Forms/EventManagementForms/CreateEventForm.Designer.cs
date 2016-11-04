namespace Forms_version_1._0
{
    partial class CreateEventForm
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
            this.lblQuantityVisitors = new System.Windows.Forms.Label();
            this.numQuantityVisitors = new System.Windows.Forms.NumericUpDown();
            this.btnRental = new System.Windows.Forms.Button();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpDateEvent = new System.Windows.Forms.DateTimePicker();
            this.lblEventDatum = new System.Windows.Forms.Label();
            this.lblEventLocatie = new System.Windows.Forms.Label();
            this.lblEventInfo = new System.Windows.Forms.Label();
            this.tbEventDescription = new System.Windows.Forms.TextBox();
            this.tbEventName = new System.Windows.Forms.TextBox();
            this.lblEventBeschrijving = new System.Windows.Forms.Label();
            this.lblEventNaam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityVisitors)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuantityVisitors
            // 
            this.lblQuantityVisitors.AutoSize = true;
            this.lblQuantityVisitors.Location = new System.Drawing.Point(8, 207);
            this.lblQuantityVisitors.Name = "lblQuantityVisitors";
            this.lblQuantityVisitors.Size = new System.Drawing.Size(83, 13);
            this.lblQuantityVisitors.TabIndex = 31;
            this.lblQuantityVisitors.Text = "Max. Bezoekers";
            // 
            // numQuantityVisitors
            // 
            this.numQuantityVisitors.Location = new System.Drawing.Point(130, 203);
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
            this.numQuantityVisitors.Size = new System.Drawing.Size(160, 20);
            this.numQuantityVisitors.TabIndex = 30;
            this.numQuantityVisitors.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnRental
            // 
            this.btnRental.Location = new System.Drawing.Point(144, 231);
            this.btnRental.Name = "btnRental";
            this.btnRental.Size = new System.Drawing.Size(148, 25);
            this.btnRental.TabIndex = 29;
            this.btnRental.Text = "Verhuur";
            this.btnRental.UseVisualStyleBackColor = true;
            this.btnRental.Click += new System.EventHandler(this.btnRental_Click);
            // 
            // cbLocation
            // 
            this.cbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Items.AddRange(new object[] {
            "Tilburg",
            "Eindhoven",
            "Amsterdam",
            "Denhaag"});
            this.cbLocation.Location = new System.Drawing.Point(130, 154);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(161, 21);
            this.cbLocation.TabIndex = 28;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(230, 262);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 43);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Opslaan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpDateEvent
            // 
            this.dtpDateEvent.Location = new System.Drawing.Point(130, 180);
            this.dtpDateEvent.Name = "dtpDateEvent";
            this.dtpDateEvent.Size = new System.Drawing.Size(161, 20);
            this.dtpDateEvent.TabIndex = 24;
            // 
            // lblEventDatum
            // 
            this.lblEventDatum.AutoSize = true;
            this.lblEventDatum.Location = new System.Drawing.Point(8, 184);
            this.lblEventDatum.Name = "lblEventDatum";
            this.lblEventDatum.Size = new System.Drawing.Size(69, 13);
            this.lblEventDatum.TabIndex = 23;
            this.lblEventDatum.Text = "Event Datum";
            // 
            // lblEventLocatie
            // 
            this.lblEventLocatie.AutoSize = true;
            this.lblEventLocatie.Location = new System.Drawing.Point(8, 159);
            this.lblEventLocatie.Name = "lblEventLocatie";
            this.lblEventLocatie.Size = new System.Drawing.Size(107, 13);
            this.lblEventLocatie.TabIndex = 22;
            this.lblEventLocatie.Text = "Locatie (dorp of stad)";
            // 
            // lblEventInfo
            // 
            this.lblEventInfo.AutoSize = true;
            this.lblEventInfo.Location = new System.Drawing.Point(91, 6);
            this.lblEventInfo.Name = "lblEventInfo";
            this.lblEventInfo.Size = new System.Drawing.Size(84, 13);
            this.lblEventInfo.TabIndex = 21;
            this.lblEventInfo.Text = "Event Informatie";
            // 
            // tbEventDescription
            // 
            this.tbEventDescription.Location = new System.Drawing.Point(130, 77);
            this.tbEventDescription.Multiline = true;
            this.tbEventDescription.Name = "tbEventDescription";
            this.tbEventDescription.Size = new System.Drawing.Size(161, 71);
            this.tbEventDescription.TabIndex = 20;
            // 
            // tbEventName
            // 
            this.tbEventName.Location = new System.Drawing.Point(130, 51);
            this.tbEventName.Name = "tbEventName";
            this.tbEventName.Size = new System.Drawing.Size(161, 20);
            this.tbEventName.TabIndex = 19;
            // 
            // lblEventBeschrijving
            // 
            this.lblEventBeschrijving.AutoSize = true;
            this.lblEventBeschrijving.Location = new System.Drawing.Point(8, 80);
            this.lblEventBeschrijving.Name = "lblEventBeschrijving";
            this.lblEventBeschrijving.Size = new System.Drawing.Size(95, 13);
            this.lblEventBeschrijving.TabIndex = 18;
            this.lblEventBeschrijving.Text = "Event Beschrijving";
            // 
            // lblEventNaam
            // 
            this.lblEventNaam.AutoSize = true;
            this.lblEventNaam.Location = new System.Drawing.Point(8, 54);
            this.lblEventNaam.Name = "lblEventNaam";
            this.lblEventNaam.Size = new System.Drawing.Size(61, 13);
            this.lblEventNaam.TabIndex = 17;
            this.lblEventNaam.Text = "Eventnaam";
            // 
            // CreateEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 318);
            this.Controls.Add(this.lblQuantityVisitors);
            this.Controls.Add(this.numQuantityVisitors);
            this.Controls.Add(this.btnRental);
            this.Controls.Add(this.cbLocation);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpDateEvent);
            this.Controls.Add(this.lblEventDatum);
            this.Controls.Add(this.lblEventLocatie);
            this.Controls.Add(this.lblEventInfo);
            this.Controls.Add(this.tbEventDescription);
            this.Controls.Add(this.tbEventName);
            this.Controls.Add(this.lblEventBeschrijving);
            this.Controls.Add(this.lblEventNaam);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CreateEventForm";
            this.Text = "CreateEventForm";
            ((System.ComponentModel.ISupportInitialize)(this.numQuantityVisitors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuantityVisitors;
        private System.Windows.Forms.NumericUpDown numQuantityVisitors;
        private System.Windows.Forms.Button btnRental;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpDateEvent;
        private System.Windows.Forms.Label lblEventDatum;
        private System.Windows.Forms.Label lblEventLocatie;
        private System.Windows.Forms.Label lblEventInfo;
        private System.Windows.Forms.TextBox tbEventDescription;
        private System.Windows.Forms.TextBox tbEventName;
        private System.Windows.Forms.Label lblEventBeschrijving;
        private System.Windows.Forms.Label lblEventNaam;
    }
}