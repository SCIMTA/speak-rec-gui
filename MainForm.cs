using NAudio.Wave;
using System;
using System.Threading;
using System.Windows.Forms;

namespace SpeakRec
{
    public partial class MainForm : Form
    {
        public Recorder recorder;
        public string audioFile = "*.wav;*.aac;*.wma;*.wmv;*.mp3";
        public string[] videoFile =
        {
            "dat", "wmv", "3g2", "3gp", "3gp2", "3gpp", "amv", "asf", "avi", "bin", "cue", "divx", "dv", "flv", "gxf", "iso", "m1v", "m2v", "m2t", "m2ts", "m4v", "mkv", "mov", "mp2", "mp2v", "mp4", "mp4v", "mpa", "mpe", "mpeg", "mpeg", "mpeg", "mpeg", "mpg", "mpv2", "mts", "nsv", "nuv", "ogg", "ogm", "ogv", "ogx", "ps", "rec", "rm", "rmvb", "tod", "ts", "tts", "vob", "vro", "webm"
        };
        public string filePath;
        public bool isVideo = false;
        public MainForm()
        {
            InitializeComponent();
            listPerson.Columns.Add("", 0);
            listPerson.Columns.Add("Tên", 300);
            listPerson.Columns.Add("Đặc trưng", 500);
            listPerson.View = View.Details;
            listPerson.GridLines = true;
            listPerson.FullRowSelect = true;
        }

  

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Mở file âm thanh";
            dlg.Filter = "All Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.filePath = dlg.FileName;
                string fileName = filePath.Split('\\')[filePath.Split('\\').Length - 1];
                labelFilePath.Text = filePath;
                labelFileName.Text = fileName;
                string ext = fileName.Split('.')[1];
                isVideo = false;
                foreach (string str in videoFile)
                    if (ext.Equals(str))
                    {
                        isVideo = true;
                        break;
                    }
                
                labelSoundLength.Text = new AudioFileReader(filePath).TotalTime.ToString().Split('.')[0];
                btnShowSub.Enabled = true;
            }
        }

        private void showSub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            string pathCmd="";
            pathCmd = '"' + filePath;
            pathCmd += '"';
            string strCmdText =  @"/K ..\..\VLC\vlc.exe " + pathCmd;
            if (!isVideo)
                strCmdText += " --audio-visual=visual --effect-list=spectrum";
            startInfo.Arguments = strCmdText;
            process.StartInfo = startInfo;
            process.Start();
        }

        private void btnShowListPerson_Click(object sender, EventArgs e)
        {
            new ListPersonForm(this).ShowDialog();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            new AddPersonForm(this).ShowDialog();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (btnRecord.Text == "Ghi âm")
            {
                btnShowSub.Enabled = false;
                btnExportText.Enabled = false;
                btnOpenFile.Enabled = false;
                btnRecord.Text = "Dừng";
                string filePath = ".\\cache\\meeting\\";
                string fileName = DateTime.Now.Ticks + ".wav";
                recorder = new Recorder(0, filePath, fileName, labelSoundLength);
                recorder.StartRecording();
                labelFilePath.Text = filePath;
                labelFileName.Text = fileName;
                this.filePath = filePath + fileName;
                string ext = fileName.Split('.')[1];
                isVideo = false;
                foreach (string str in videoFile)
                    if (ext.Equals(str))
                    {
                        isVideo = true;
                        break;
                    }
            }
            else
            {
                StopRecord();
            }
        }

        private void StopRecord()
        {
            recorder.RecordEnd();
            btnShowSub.Enabled = true;
            btnExportText.Enabled = true;
            btnOpenFile.Enabled = true;
            btnRecord.Text = "Ghi âm";
        }
    }
}
