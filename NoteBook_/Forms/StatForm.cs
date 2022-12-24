using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteBook_.Forms
{
    public partial class StatForm : Form
    {
        private readonly WorkingWithDB DB;
        private DateTime currentdate;
        public StatForm(WorkingWithDB DB)
        {
            this.DB = DB;
            InitializeComponent();
            currentdate= DateTime.Now;
            monthlabel.Text = currentdate.ToString("MMMM");
            UpdateChart();
        }

        void UpdateChart()
        {

            var stat = DB.GetStat(currentdate.Month.ToString().PadLeft(2,'0'), currentdate.Year);


            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            chart1.Titles.Clear();


            chart1.Titles.Add("Статитика планов на " + currentdate.ToString("MMMM") + " " + currentdate.Year);
            chart1.Series["s1"].IsValueShownAsLabel = true;

            for (int i = 0; i < 32; i++)
            {
                chart1.Series["s1"].Points.AddXY(i, 0);
                foreach (var el in stat)
                {
                    if (el.Item1.Day == i)
                    {
                        chart1.Series["s1"].Points.AddXY(i, el.Item2);
                    }
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentdate= currentdate.AddMonths(-1);
            monthlabel.Text = currentdate.ToString("MMMM");
            UpdateChart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentdate= currentdate.AddMonths(1);
            monthlabel.Text = currentdate.ToString("MMMM");
            UpdateChart();
        }
    }
}
