using System;
using System.Collections.Generic;
using System.IO;
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
            listViewPerson.Columns.Add("Tên", 500);
            listViewPerson.View = View.Details;
            listViewPerson.GridLines = true;
            listViewPerson.FullRowSelect = true;
            loadListAllPersonSaved();
        }

        private void loadListAllPersonSaved()
        {
            API.GetListPerson(resPerson =>
           {
               List<Person> listPerson = resPerson.data;

               API.GetListJoin(resJoin =>
               {
                   List<Person> listJoin = resJoin.data;
                   listViewPerson.Items.Clear();
                   ListViewItem itm;
                   for (int i = 0; i < listPerson.Count; i++)
                   {
                       itm = new ListViewItem(new string[] {
                "",listPerson[i].name });
                       foreach (Person join in listJoin)
                           if (join.name.Equals(listPerson[i].name))
                               itm.Checked = true;
                       listViewPerson.Items.Add(itm);
                   }
               });
           });
        }

        private void listViewPerson_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            ListViewItem item = listViewPerson.Items[e.Index];
            string label = item.SubItems[1].Text;
            bool isCheck = e.NewValue == CheckState.Checked;
            API.EditJoin(label, isCheck, () =>
            {
            });
        }

        private void ListPersonForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.loadListJoin();
        }
    }
}
