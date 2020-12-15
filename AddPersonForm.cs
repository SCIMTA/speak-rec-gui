using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeakRec
{
    public partial class AddPersonForm : Form
    {
        public Recorder recorder;
        public string placeholder = "Nhập tên";
        private MainForm mainForm;
        public AddPersonForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
           if(btnRecord.Text=="Ghi âm")
            {
                btnRecord.Text = "Dừng";
                string filePath = ".\\cache\\person\\";
                string fileName = DateTime.Now.Ticks + ".wav";
                recorder = new Recorder(0, filePath , fileName,lablelRec);
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
            Utils.AddPerson(new Person(tbName.Text, "500"));
            int lastIndex = Utils.getListPerson().Count;
            ListViewItem itm = new ListViewItem(new string[] {
                "",tbName.Text,"500"
                });
            itm.Tag = lastIndex - 1;
            mainForm.listPerson.Items.Add(itm);
            btnRecord.Text = "Ghi âm";
            tbName.Text = String.Empty;
            lablelRec.Text = "00:00:00";
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if(tbName.Text != String.Empty)
                btnRecord.Enabled = true;
            else
                btnRecord.Enabled = false;
        }

        private void AddPersonForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (btnRecord.Text != "Ghi âm"&&tbName.Text!=String.Empty)
                StopRecord();
        }
    }
}
