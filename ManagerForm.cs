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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
            listView1.Columns.Add("Tên", 300);
            listView1.Columns.Add("Đặc trưng", 500);
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            loadListAllPersonSaved();
        }

        private void loadListAllPersonSaved()
        {
            List<Person> listPerson = Utils.getListPerson();
            listView1.Items.Clear();
            ListViewItem itm;
            for (int i = 0; i < listPerson.Count; i++)
            {
                itm = new ListViewItem(new string[] {
                listPerson[i].name });
                listView1.Items.Add(itm);
            }
        }

        private void addPersonBtn(object sender, EventArgs e)
        {
            new AddPersonForm().ShowDialog();
        }
    }
}
