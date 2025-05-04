using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string a = dateTimePicker1.Value.ToLongDateString();
            textBox1.Text = a;
            monthCalendar1.TodayDate = dateTimePicker1.Value;
            monthCalendar1.ShowToday = false;
            monthCalendar1.SelectionStart = dateTimePicker1.Value;
            monthCalendar1.SelectionEnd = dateTimePicker1.Value;
            monthCalendar1.ShowWeekNumbers = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = dateTimePicker1.Value.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int year = r.Next(2007, 2025);
            int month = r.Next(1, 12);
            int day = r.Next(1, 28);
            monthCalendar1.TodayDate = new DateTime(year, month, day);
            monthCalendar1.ShowToday = false;
            monthCalendar1.SelectionStart = new DateTime(year, month, day);
            monthCalendar1.SelectionEnd = new DateTime(year, month, day);
            monthCalendar1.ShowWeekNumbers = true;
            dateTimePicker1.Value = monthCalendar1.TodayDate;
        }

        
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            dateTimePicker1.Value = monthCalendar1.SelectionStart.Date;
        }

    }
}
