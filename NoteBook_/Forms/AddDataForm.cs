using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBook_
{
    public partial class AddDataForm : Form
    {
        private WorkingWithDB DB;
        public AddDataForm(WorkingWithDB DB)
        {
            this.DB = DB;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TitleBox.Text.Trim() == "" || descBox.Text.Trim() == "")
            {
                MessageBox.Show("Не нужно вводить пустые поля");
                return;
            }

            DataStructure data = new()
            {
                Date = DateTime.Parse(DateBox.Text),
                Title = TitleBox.Text,
                Description = descBox.Text,
                IsDone = GetBool(false),
            };
            DB.AddData(data);
            TitleBox.Text = "";
            descBox.Text = "";


        }
        string GetBool(bool flag)
        {
            return flag ? "Заверешен" : "Не завершен";
        }
    }
}
