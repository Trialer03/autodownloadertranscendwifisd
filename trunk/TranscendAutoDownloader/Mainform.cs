using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace TranscendAutoDownloader
{
    public partial class Mainform : Form
    {
        private bool _ipErreichbar;
        private string _SelectedIP = "";

        public Mainform()
        {
            InitializeComponent();
        }

        private bool IpErreichbar
        {
            get { return _ipErreichbar; }
            set
            {
                _ipErreichbar = value;
                if (value)
                {
                    pcbStatus.Image = TranscendAutoDownloader.Properties.Resources.green_led_on_md;
                    btnSucheQuellPfad.Enabled = true;
                    timerGetActuallyFilelist.Enabled = true;
                }
                else
                {
                    pcbStatus.Image = TranscendAutoDownloader.Properties.Resources.red_led_on_md;
                    btnSucheQuellPfad.Enabled = false;
                    lblPingZeit.Text = "";
                    timerGetActuallyFilelist.Enabled = false;
                }

            }
        }


        private void timerCheckIP_Tick(object sender, EventArgs e)
        {
            Ping Sender = new Ping();
            PingReply Result = Sender.Send(cmbIP.Text, 1500);
            if (Result.Status == IPStatus.Success)
            {
                lblPingZeit.Text = Result.RoundtripTime.ToString();
                IpErreichbar = true;
            }
            else
            {

                IpErreichbar = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (timerCheckIP.Enabled)
            {
                timerCheckIP.Enabled = false;
                btnStart.Text = "Starte Überwachung";
                pcbStatus.Image = TranscendAutoDownloader.Properties.Resources.red_led_on_md;
                timerGetActuallyFilelist.Enabled = false;
            }
            else
            {
                timerCheckIP.Enabled = true;
                btnStart.Text = "Stoppe Überwachung";
                

            }
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            lblPingZeit.Text = "";
            cmbPollingTime.SelectedItem = Properties.Settings.Default.lastPollingTime;
            fbdSpeicherpfad.SelectedPath = Properties.Settings.Default.Speicherpfad;
            fbdImportOrdner.SelectedPath = Properties.Settings.Default.ImportOrdner;
            _SelectedIP = cmbIP.Text;
        }

        private void btnSucheSpeicherPfad_Click(object sender, EventArgs e)
        {
            fbdSpeicherpfad.ShowDialog();
            txtSpeicherpfad.Text = fbdSpeicherpfad.SelectedPath;
            Properties.Settings.Default.Speicherpfad = fbdSpeicherpfad.SelectedPath;

        }

        private void Mainform_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.lastPollingTime = cmbPollingTime.SelectedItem.ToString();
            Properties.Settings.Default.Save();
        }

        private void cmbPollingTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            timerGetActuallyFilelist.Interval = Int32.Parse(cmbPollingTime.SelectedItem.ToString()) * 1000;
        }

        private void timerGetActuallyFilelist_Tick(object sender, EventArgs e)
        {
            if (!bgwFrageNeueListeAb.IsBusy)
            {
                bgwFrageNeueListeAb.RunWorkerAsync();
            }
        }

        private void bgwFrageNeueListeAb_DoWork(object sender, DoWorkEventArgs e)
        {
            Random r = new Random();

            var para = new Dictionary<string, string>
            {
                {"PATH", Properties.Settings.Default.QuellRoot + txtQuelleAufSD.Text},
                {"keeprefresh", r.Next(Int32.MaxValue).ToString()}
            };

            Uri adresse = new Uri("http://" + _SelectedIP + "/cgi-bin/tslist");

            var filesAufSD = new ParseTsList(TranscendAutoDownloader.DownloaderClass.GetHttpFile(adresse, para));

            LadeDifferenzen(filesAufSD, txtSpeicherpfad.Text, Properties.Settings.Default.QuellRoot + txtQuelleAufSD.Text);

        }

        private void LadeDifferenzen(ParseTsList filesAufSd, string speicherpfad, string SDQuelle)
        {
            foreach (string filenameAufSD in filesAufSd.listeDateien)
            {
                var test1 = File.Exists(speicherpfad + "\\" + filenameAufSD);
                var test2 = txtImportOrdner.Text.Length > 5 && File.Exists(Properties.Settings.Default.ImportOrdner + "\\" + filenameAufSD);


                if (!test1 && !test2)
                {
                    DownloadeFile(SDQuelle, filenameAufSD, speicherpfad);
                }
            }
        }

        private void DownloadeFile(string Quellpfad, string quelleFilename, string speicherpfad)
        {
            if (!_ipErreichbar) return;
            // http://192.168.1.30/cgi-bin/wifi_download?fn=IMG_8457.CR2&fd=%2Fwww%2Fsd%2FDCIM%2F100CANON


            var dict = new Dictionary<string, string>();
            dict.Add("fn",quelleFilename);
            dict.Add("fd",Quellpfad);
            var uriFile = new Uri("http://"+_SelectedIP +"/cgi-bin/wifi_download");
            DownloaderClass.DownloadFile(uriFile, dict,speicherpfad + "\\"+ quelleFilename);

        }

        private void cmbIP_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SelectedIP = cmbIP.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var t = new ParseTsList("jk");
        }

        private void txtSpeicherpfad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSetImportOrdner_Click(object sender, EventArgs e)
        {
            fbdImportOrdner.ShowDialog();
            txtImportOrdner.Text = fbdImportOrdner.SelectedPath;
            Properties.Settings.Default.ImportOrdner = txtImportOrdner.Text;

        }
    }
}
