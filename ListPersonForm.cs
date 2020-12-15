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
        public ListPersonForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            listViewPerson.CheckBoxes = true;
            listViewPerson.Columns.Add("Tham gia", 100);
            listViewPerson.Columns.Add("Tên", 300);
            listViewPerson.Columns.Add("Đặc trưng", 500);
            listViewPerson.View = View.Details;
            listViewPerson.GridLines = true;
            listViewPerson.FullRowSelect = true;
            List<Person> listPerson = Utils.getListPerson();

            ListViewItem itm;
            for (int i = 0; i < listPerson.Count; i++)
            {
                itm = new ListViewItem(new string[] {
                "",listPerson[i].name,listPerson[i].featured });
                itm.Tag = i;
                listViewPerson.Items.Add(itm);
            }
            foreach(ListViewItem item in mainForm.listPerson.Items)
            {
                try
                {
                    listViewPerson.Items[(int)item.Tag].Checked = true;
                }
                catch (Exception)
                {

                }
            }
        }


        private void listViewPerson_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            mainForm.listPerson.Items.Clear();
            ListViewItem itm;
            foreach (ListViewItem listViewItem in listViewPerson.Items)
            {
                if (listViewItem.Checked)
                {
                    itm = (ListViewItem)listViewItem.Clone();
                    mainForm.listPerson.Items.Add(itm);
                }
            }

        }
    }
}
