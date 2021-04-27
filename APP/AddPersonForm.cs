using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeakRec
{
    public partial class AddPersonForm : Form
    {
        public Recorder recorder;
        private ManagerForm managerForm;
        public string placeholder = "Nhập tên";
        private string filePath;
        private string fileName;
        public AddPersonForm(ManagerForm managerForm)
        {
            InitializeComponent();
            this.managerForm = managerForm;
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (btnRecord.Tag.ToString().Equals("r"))
            {
                btnRecord.Tag = "s";
                filePath = ".\\cache\\person\\";
                fileName = DateTime.Now.Ticks + ".wav";
                recorder = new Recorder(0, filePath, fileName, labelRec);
                recorder.StartRecording();
            }
            else
            {
                StopRecord();
            }
        }

        private void StopRecord()
        {
            recorder.RecordEnd();
            API.AddPerson("." + filePath + fileName, tbName.Text, json =>
            {
                onAddSuccess(json);
            });

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if (tbName.Text != String.Empty)
            {
                btnRecord.Enabled = true;
                btnOpenFile.Enabled = true;
            }
            else
            {
                btnRecord.Enabled = false;
                btnOpenFile.Enabled = false;
            }
        }

        private void AddPersonForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (btnRecord.Text != "Ghi âm" && tbName.Text != String.Empty)
                StopRecord();
            managerForm.loadListAllPersonSaved();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.RestoreDirectory = false;
            dlg.InitialDirectory = Environment.CurrentDirectory;
            dlg.Title = "Mở file âm thanh";
            dlg.Filter = "All Media Files|*.wav;*.aac;*.wma;*.wmv;*.mp3;*.mpa;*.mpe;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.filePath = dlg.FileName;
                API.AddPerson(filePath, tbName.Text, json =>
                {
                    onAddSuccess(json);
                });
            }
        }


        private void onAddSuccess(AddPerson addPerson)
        {
            btnRecord.Text = "Ghi âm";
            tbName.Text = String.Empty;
            labelRec.Text = "00:00:00";
            MessageBox.Show("Thêm " + tbName.Text + " thành công");
        }
    }
}
