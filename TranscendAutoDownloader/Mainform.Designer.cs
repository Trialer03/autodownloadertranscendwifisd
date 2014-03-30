namespace TranscendAutoDownloader
{
    partial class Mainform
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.bgwFrageNeueListeAb = new System.ComponentModel.BackgroundWorker();
            this.timerCheckIP = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.pcbStatus = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSucheSpeicherPfad = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSucheQuellPfad = new System.Windows.Forms.Button();
            this.fbdSpeicherpfad = new System.Windows.Forms.FolderBrowserDialog();
            this.timerGetActuallyFilelist = new System.Windows.Forms.Timer(this.components);
            this.cmbPollingTime = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPingZeit = new System.Windows.Forms.Label();
            this.btnSetImportOrdner = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.fbdImportOrdner = new System.Windows.Forms.FolderBrowserDialog();
            this.txtImportOrdner = new System.Windows.Forms.TextBox();
            this.txtQuelleAufSD = new System.Windows.Forms.TextBox();
            this.txtSpeicherpfad = new System.Windows.Forms.TextBox();
            this.cmbIP = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wifi-SD IP:";
            // 
            // bgwFrageNeueListeAb
            // 
            this.bgwFrageNeueListeAb.WorkerReportsProgress = true;
            this.bgwFrageNeueListeAb.WorkerSupportsCancellation = true;
            this.bgwFrageNeueListeAb.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwFrageNeueListeAb_DoWork);
            // 
            // timerCheckIP
            // 
            this.timerCheckIP.Interval = 1500;
            this.timerCheckIP.Tick += new System.EventHandler(this.timerCheckIP_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(490, 9);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(323, 36);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Starte Überwachung";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pcbStatus
            // 
            this.pcbStatus.Image = global::TranscendAutoDownloader.Properties.Resources.red_led_on_md;
            this.pcbStatus.Location = new System.Drawing.Point(967, 12);
            this.pcbStatus.Name = "pcbStatus";
            this.pcbStatus.Size = new System.Drawing.Size(102, 85);
            this.pcbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbStatus.TabIndex = 5;
            this.pcbStatus.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Speicher-Pfad:";
            // 
            // btnSucheSpeicherPfad
            // 
            this.btnSucheSpeicherPfad.Location = new System.Drawing.Point(674, 50);
            this.btnSucheSpeicherPfad.Name = "btnSucheSpeicherPfad";
            this.btnSucheSpeicherPfad.Size = new System.Drawing.Size(58, 34);
            this.btnSucheSpeicherPfad.TabIndex = 8;
            this.btnSucheSpeicherPfad.Text = "...";
            this.btnSucheSpeicherPfad.UseVisualStyleBackColor = true;
            this.btnSucheSpeicherPfad.Click += new System.EventHandler(this.btnSucheSpeicherPfad_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quell-Pfad:";
            // 
            // btnSucheQuellPfad
            // 
            this.btnSucheQuellPfad.Location = new System.Drawing.Point(674, 126);
            this.btnSucheQuellPfad.Name = "btnSucheQuellPfad";
            this.btnSucheQuellPfad.Size = new System.Drawing.Size(58, 34);
            this.btnSucheQuellPfad.TabIndex = 11;
            this.btnSucheQuellPfad.Text = "...";
            this.btnSucheQuellPfad.UseVisualStyleBackColor = true;
            // 
            // fbdSpeicherpfad
            // 
            this.fbdSpeicherpfad.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // timerGetActuallyFilelist
            // 
            this.timerGetActuallyFilelist.Interval = 5000;
            this.timerGetActuallyFilelist.Tick += new System.EventHandler(this.timerGetActuallyFilelist_Tick);
            // 
            // cmbPollingTime
            // 
            this.cmbPollingTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPollingTime.FormattingEnabled = true;
            this.cmbPollingTime.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10",
            "20",
            "30",
            "60",
            "120",
            "180",
            "300",
            "600"});
            this.cmbPollingTime.Location = new System.Drawing.Point(877, 48);
            this.cmbPollingTime.Name = "cmbPollingTime";
            this.cmbPollingTime.Size = new System.Drawing.Size(48, 36);
            this.cmbPollingTime.TabIndex = 12;
            this.cmbPollingTime.SelectedIndexChanged += new System.EventHandler(this.cmbPollingTime_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(861, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "Polling:";
            // 
            // lblPingZeit
            // 
            this.lblPingZeit.BackColor = System.Drawing.Color.Transparent;
            this.lblPingZeit.Location = new System.Drawing.Point(967, 100);
            this.lblPingZeit.Name = "lblPingZeit";
            this.lblPingZeit.Size = new System.Drawing.Size(102, 28);
            this.lblPingZeit.TabIndex = 14;
            this.lblPingZeit.Text = "label6";
            this.lblPingZeit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSetImportOrdner
            // 
            this.btnSetImportOrdner.Location = new System.Drawing.Point(674, 86);
            this.btnSetImportOrdner.Name = "btnSetImportOrdner";
            this.btnSetImportOrdner.Size = new System.Drawing.Size(58, 34);
            this.btnSetImportOrdner.TabIndex = 18;
            this.btnSetImportOrdner.Text = "...";
            this.btnSetImportOrdner.UseVisualStyleBackColor = true;
            this.btnSetImportOrdner.Click += new System.EventHandler(this.btnSetImportOrdner_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 28);
            this.label6.TabIndex = 16;
            this.label6.Text = "Import Ordner:";
            // 
            // fbdImportOrdner
            // 
            this.fbdImportOrdner.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // txtImportOrdner
            // 
            this.txtImportOrdner.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TranscendAutoDownloader.Properties.Settings.Default, "ImportOrdner", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtImportOrdner.Enabled = false;
            this.txtImportOrdner.Location = new System.Drawing.Point(152, 86);
            this.txtImportOrdner.Name = "txtImportOrdner";
            this.txtImportOrdner.Size = new System.Drawing.Size(516, 34);
            this.txtImportOrdner.TabIndex = 17;
            this.txtImportOrdner.Text = global::TranscendAutoDownloader.Properties.Settings.Default.ImportOrdner;
            // 
            // txtQuelleAufSD
            // 
            this.txtQuelleAufSD.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TranscendAutoDownloader.Properties.Settings.Default, "QuellPfad", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtQuelleAufSD.Enabled = false;
            this.txtQuelleAufSD.Location = new System.Drawing.Point(152, 126);
            this.txtQuelleAufSD.Name = "txtQuelleAufSD";
            this.txtQuelleAufSD.Size = new System.Drawing.Size(516, 34);
            this.txtQuelleAufSD.TabIndex = 10;
            this.txtQuelleAufSD.Text = global::TranscendAutoDownloader.Properties.Settings.Default.QuellPfad;
            // 
            // txtSpeicherpfad
            // 
            this.txtSpeicherpfad.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TranscendAutoDownloader.Properties.Settings.Default, "Speicherpfad", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtSpeicherpfad.Enabled = false;
            this.txtSpeicherpfad.Location = new System.Drawing.Point(152, 50);
            this.txtSpeicherpfad.Name = "txtSpeicherpfad";
            this.txtSpeicherpfad.Size = new System.Drawing.Size(516, 34);
            this.txtSpeicherpfad.TabIndex = 7;
            this.txtSpeicherpfad.Text = global::TranscendAutoDownloader.Properties.Settings.Default.Speicherpfad;
            this.txtSpeicherpfad.TextChanged += new System.EventHandler(this.txtSpeicherpfad_TextChanged);
            // 
            // cmbIP
            // 
            this.cmbIP.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TranscendAutoDownloader.Properties.Settings.Default, "letzteIP", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbIP.FormattingEnabled = true;
            this.cmbIP.Items.AddRange(new object[] {
            "192.168.1.29"});
            this.cmbIP.Location = new System.Drawing.Point(119, 9);
            this.cmbIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbIP.Name = "cmbIP";
            this.cmbIP.Size = new System.Drawing.Size(351, 36);
            this.cmbIP.TabIndex = 0;
            this.cmbIP.Text = global::TranscendAutoDownloader.Properties.Settings.Default.letzteIP;
            this.cmbIP.SelectedIndexChanged += new System.EventHandler(this.cmbIP_SelectedIndexChanged);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 191);
            this.Controls.Add(this.btnSetImportOrdner);
            this.Controls.Add(this.txtImportOrdner);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPingZeit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbPollingTime);
            this.Controls.Add(this.btnSucheQuellPfad);
            this.Controls.Add(this.txtQuelleAufSD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSucheSpeicherPfad);
            this.Controls.Add(this.txtSpeicherpfad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pcbStatus);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbIP);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Mainform";
            this.Text = "Auto-Download for Transcend Wifi-SD";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mainform_FormClosed);
            this.Load += new System.EventHandler(this.Mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIP;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker bgwFrageNeueListeAb;
        private System.Windows.Forms.Timer timerCheckIP;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pcbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpeicherpfad;
        private System.Windows.Forms.Button btnSucheSpeicherPfad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuelleAufSD;
        private System.Windows.Forms.Button btnSucheQuellPfad;
        private System.Windows.Forms.FolderBrowserDialog fbdSpeicherpfad;
        private System.Windows.Forms.Timer timerGetActuallyFilelist;
        private System.Windows.Forms.ComboBox cmbPollingTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPingZeit;
        private System.Windows.Forms.Button btnSetImportOrdner;
        private System.Windows.Forms.TextBox txtImportOrdner;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FolderBrowserDialog fbdImportOrdner;
    }
}

