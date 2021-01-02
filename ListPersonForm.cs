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
    public partial class ListPersonForm : Form
    {
        private MainForm mainForm;
        private int currentItemSelected = -1;
        public ListPersonForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            listViewPerson.CheckBoxes = true;
            listViewPerson.Columns.Add("Tham gia", 100);
            listViewPerson.Columns.Add("Tên", 500);
            listViewPerson.View = View.Details;
            listViewPerson.GridLines = true;
            listViewPerson.FullRowSelect = true;
            loadListAllPersonSaved();
        }

        private void loadListAllPersonSaved()
        {
            List<Person> listPerson = Utils.getListPerson();
            listViewPerson.Items.Clear();
            ListViewItem itm;
            for (int i = 0; i < listPerson.Count; i++)
            {
                itm = new ListViewItem(new string[] {
                "",listPerson[i].name });
                listViewPerson.Items.Add(itm);
            }
            foreach (ListViewItem item in mainForm.listPerson.Items)
                foreach (ListViewItem viewItem in listViewPerson.Items)
                    if (item.Checked && item.SubItems[1].Text == viewItem.SubItems[1].Text)
                        viewItem.Checked = true;
        }

        private void listViewPerson_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            reloadForm();
        }

        private void reloadForm()
        {
            mainForm.listPerson.Items.Clear();
            ListViewItem itm;
            string createText = "label\n";
            foreach (ListViewItem listViewItem in listViewPerson.Items)
            {
                if (listViewItem.Checked)
                {
                    itm = (ListViewItem)listViewItem.Clone();
                    createText += itm.SubItems[1].Text + "\n";
                    mainForm.listPerson.Items.Add(itm);
                }
            }
            File.WriteAllText(@".\speak-rec\data\join.csv", createText);

            if (mainForm.listPerson.Items.Count > 0)
            {
                Utils.enableButton(mainForm.btnRecord, Properties.Resources.record, mainForm.recordToolStripMenuItem);
                Utils.enableButton(mainForm.btnOpenFile, Properties.Resources.open, mainForm.openFileToolStripMenuItem);
            }
            else
            {
                Utils.disableButton(mainForm.btnRecord, Properties.Resources.record, mainForm.recordToolStripMenuItem);
                Utils.disableButton(mainForm.btnOpenFile, Properties.Resources.open, mainForm.openFileToolStripMenuItem);
            }
        }

        private void listViewPerson_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listViewPerson.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip.Show(Cursor.Position);
                }
            }
        }

        private void listViewPerson_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            this.currentItemSelected = e.ItemIndex;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Person> listPerson = Utils.getListPerson();
            listPerson.RemoveAt(currentItemSelected);
            Utils.replaceListPerson(listPerson);
            loadListAllPersonSaved();
            reloadForm();
        }
    }
}
