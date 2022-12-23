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
    public partial class EditDateForm : Form
    {
        private WorkingWithDB DB;
        private int id;
        public EditDateForm(WorkingWithDB DB, int id, DataStructure currDataStructure)
        {
            this.DB = DB;
            this.id = id;
            InitializeComponent();

            DateBox.Text = currDataStructure.Date.ToShortDateString();
            TitleBox.Text = currDataStructure.Title;
            descBox.Text = currDataStructure.Description;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataStructure data = new()
            {
                Date = DateTime.Parse(DateBox.Text),
                Title = TitleBox.Text,
                Description = descBox.Text,
                IsDone = GetBool(checkbox.Checked)
            };
            DB.UpdateDateById(id, data);
            Hide();
        }
        string GetBool(bool flag)
        {
            return flag ? "Заверешен" : "Не завершен";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Удалить?", "Помощь", MessageBoxButtons.YesNo);

            switch (dialogResult)
            {
                case DialogResult.Yes:
                    DB.DeleteById(id);
                    Hide();
                    break;
                case DialogResult.No:
                    break;

            }
        }

        protected override void OnClosed(EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Сохранить изменения?", "Помощь", MessageBoxButtons.YesNo);

            switch (dialogResult)
            {
                case DialogResult.Yes:
                    DataStructure data = new()
                    {
                        Date = DateTime.Parse(DateBox.Text),
                        Title = TitleBox.Text,
                        Description = descBox.Text,
                        IsDone = GetBool(checkbox.Checked)
                    };
                    DB.UpdateDateById(id, data);
                    Hide();
                    break;
                case DialogResult.No:
                    break;

            }
        }
    }
}
