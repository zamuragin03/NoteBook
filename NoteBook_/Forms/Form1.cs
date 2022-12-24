using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteBook_.Forms;

namespace NoteBook_
{
    public partial class Form1 : Form
    {
        private readonly WorkingWithDB DB;
        public Form1()
        {
            InitializeComponent();

            DB = WorkingWithDB.GetInstance();
            UpdateListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDataForm f = new(DB);
            f.Show();
        }

        void UpdateListView()
        {
            var list = DB.GetData();
            listView1.Items.Clear();

            foreach (var el in list)
            {
                var item = new ListViewItem(el);
                listView1.Items.Add(item);
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            var tst = DB.GetDataByID(id);
            ObserveForm f = new(tst);
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                var tst = DB.GetDataByID(id);

                EditDateForm f = new(DB, id, tst);
                f.Show();

            }
            catch (Exception)
            {
                MessageBox.Show("Не выбрана");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            StatForm f = new(DB);
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateListView();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var list = DB.GetDataByDay(DateTime.Now);
            listView1.Items.Clear();

            foreach (var el in list)
            {
                var item = new ListViewItem(el);
                listView1.Items.Add(item);
            }
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            var list = DB.GetSortedDataByCat(listView1.Columns[e.Column].Text);
            listView1.Items.Clear();

            foreach (var el in list)
            {
                var item = new ListViewItem(el);
                listView1.Items.Add(item);
            }

        }
    }
}
