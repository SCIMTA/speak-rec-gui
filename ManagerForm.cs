using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeakRec
{
    public partial class ManagerForm : Form
    {
        private int indexSelected = -1;
        private MainForm mainForm;
        public ManagerForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            listPersonManager.Columns.Add("Tên", 500);
            listPersonManager.View = View.Details;
            listPersonManager.GridLines = true;
            listPersonManager.FullRowSelect = true;
            loadListAllPersonSaved();
        }

        public void loadListAllPersonSaved()
        {
            API.GetListPerson(list =>
            {
                List<Person> listPerson = list.data;
                listPersonManager.Items.Clear();
                ListViewItem itm;
                for (int i = 0; i < listPerson.Count; i++)
                {
                    itm = new ListViewItem(new string[] {
                listPerson[i].name });
                    listPersonManager.Items.Add(itm);
                }
            });

        }

        private void addPersonBtn(object sender, EventArgs e)
        {
            new AddPersonForm(this).ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (indexSelected != -1)
            {
                API.RemovePerson(listPersonManager.Items[indexSelected].SubItems[0].Text, () =>
                {
                });
                Thread.Sleep(100);
                loadListAllPersonSaved();
            }
        }

        private void listPersonManager_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                if (listPersonManager.FocusedItem.Bounds.Contains(e.Location))
                    contextMenuDelete.Show(Cursor.Position);
        }

        private void listPersonManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPersonManager.SelectedIndices.Count > 0)
                indexSelected = listPersonManager.SelectedIndices[0];
        }

        private void ManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.loadListJoin();
        }
    }
}
