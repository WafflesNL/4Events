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
            this.tbEventNaam = new System.Windows.Forms.TextBox();
            this.tbEventBeschrijving = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblEventInfo = new System.Windows.Forms.Label();
            this.lblEventLocatie = new System.Windows.Forms.Label();
            this.tbEventLocatie = new System.Windows.Forms.TextBox();
            this.lblEventDatum = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.btnNietOpslaan = new System.Windows.Forms.Button();
            this.btnOverzicht = new System.Windows.Forms.Button();
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
            // tbEventNaam
            // 
            this.tbEventNaam.Location = new System.Drawing.Point(149, 54);
            this.tbEventNaam.Name = "tbEventNaam";
            this.tbEventNaam.Size = new System.Drawing.Size(146, 20);
            this.tbEventNaam.TabIndex = 2;
            // 
            // tbEventBeschrijving
            // 
            this.tbEventBeschrijving.Location = new System.Drawing.Point(149, 80);
            this.tbEventBeschrijving.Multiline = true;
            this.tbEventBeschrijving.Name = "tbEventBeschrijving";
            this.tbEventBeschrijving.Size = new System.Drawing.Size(146, 71);
            this.tbEventBeschrijving.TabIndex = 3;
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
            this.lblEventLocatie.Location = new System.Drawing.Point(12, 159);
            this.lblEventLocatie.Name = "lblEventLocatie";
            this.lblEventLocatie.Size = new System.Drawing.Size(73, 13);
            this.lblEventLocatie.TabIndex = 5;
            this.lblEventLocatie.Text = "Event Locatie";
            // 
            // tbEventLocatie
            // 
            this.tbEventLocatie.Location = new System.Drawing.Point(149, 156);
            this.tbEventLocatie.Name = "tbEventLocatie";
            this.tbEventLocatie.Size = new System.Drawing.Size(146, 20);
            this.tbEventLocatie.TabIndex = 6;
            // 
            // lblEventDatum
            // 
            this.lblEventDatum.AutoSize = true;
            this.lblEventDatum.Location = new System.Drawing.Point(12, 188);
            this.lblEventDatum.Name = "lblEventDatum";
            this.lblEventDatum.Size = new System.Drawing.Size(69, 13);
            this.lblEventDatum.TabIndex = 7;
            this.lblEventDatum.Text = "Event Datum";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 182);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(233, 324);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(62, 43);
            this.btnOpslaan.TabIndex = 9;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            // 
            // btnNietOpslaan
            // 
            this.btnNietOpslaan.Location = new System.Drawing.Point(12, 324);
            this.btnNietOpslaan.Name = "btnNietOpslaan";
            this.btnNietOpslaan.Size = new System.Drawing.Size(62, 43);
            this.btnNietOpslaan.TabIndex = 10;
            this.btnNietOpslaan.Text = "Niet Opslaan";
            this.btnNietOpslaan.UseVisualStyleBackColor = true;
            // 
            // btnOverzicht
            // 
            this.btnOverzicht.Location = new System.Drawing.Point(149, 208);
            this.btnOverzicht.Name = "btnOverzicht";
            this.btnOverzicht.Size = new System.Drawing.Size(146, 25);
            this.btnOverzicht.TabIndex = 11;
            this.btnOverzicht.Text = "GastenOverzicht";
            this.btnOverzicht.UseVisualStyleBackColor = true;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 379);
            this.Controls.Add(this.btnOverzicht);
            this.Controls.Add(this.btnNietOpslaan);
            this.Controls.Add(this.btnOpslaan);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblEventDatum);
            this.Controls.Add(this.tbEventLocatie);
            this.Controls.Add(this.lblEventLocatie);
            this.Controls.Add(this.lblEventInfo);
            this.Controls.Add(this.tbEventBeschrijving);
            this.Controls.Add(this.tbEventNaam);
            this.Controls.Add(this.lblEventBeschrijving);
            this.Controls.Add(this.lblEventNaam);
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEventNaam;
        private System.Windows.Forms.Label lblEventBeschrijving;
        private System.Windows.Forms.TextBox tbEventNaam;
        private System.Windows.Forms.TextBox tbEventBeschrijving;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lblEventInfo;
        private System.Windows.Forms.Label lblEventLocatie;
        private System.Windows.Forms.TextBox tbEventLocatie;
        private System.Windows.Forms.Label lblEventDatum;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Button btnNietOpslaan;
        private System.Windows.Forms.Button btnOverzicht;
    }
}