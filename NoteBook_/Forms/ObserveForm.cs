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
    public partial class ObserveForm : Form
    {
        public ObserveForm(DataStructure data)
        {
            InitializeComponent();
            descBox.Text = data.Description;
            seldatelabel.Text = data.Date.ToShortDateString();
            titlelabel.Text = data.Title;
        }
    }
}
