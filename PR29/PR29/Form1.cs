using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox4.Text = ($"X = {textBox1.Text}");
            textBox4.Text += Environment.NewLine + ($"Y = {textBox2.Text}"); ;
            textBox4.Text += Environment.NewLine + ($"Z = {textBox3.Text}"); ;
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = ($"X = {textBox1.Text}");
            textBox4.Text += Environment.NewLine + ($"Y = {textBox2.Text}"); ;
            textBox4.Text += Environment.NewLine + ($"Z = {textBox3.Text}"); ;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = ($"X = {textBox1.Text}");
            textBox4.Text += Environment.NewLine + ($"Y = {textBox2.Text}"); ;
            textBox4.Text += Environment.NewLine + ($"Z = {textBox3.Text}"); ;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = ($"X = {textBox1.Text}");
            textBox4.Text += Environment.NewLine + ($"Y = {textBox2.Text}");
            textBox4.Text += Environment.NewLine + ($"Z = {textBox3.Text}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            double z = double.Parse(textBox3.Text);
            
            double u = Math.Pow(Math.Tan(x + y), 2) - Math.Exp(y - z) * Math.Sqrt(Math.Cos(Math.Pow(x, 2) + Math.Sin(Math.Pow(z, 2))));
            textBox4.Text += Environment.NewLine + ($"U = {u}");

            double t = ((2 * Math.Cos(x - (3.14 / 6))) / (0.5 + Math.Pow(Math.Sin(y), 2))) * (1 + (Math.Pow(z, 2) / (3 - (Math.Pow(z, 2) / 5))));
            textBox4.Text += Environment.NewLine + ($"T = {t}");

            double u2 = (Math.Pow((8 + Math.Pow(Math.Abs(x - y), 2) + 1), (1 / 3)) / (Math.Pow(x, 2) + Math.Pow(y, 2) + 2)) - Math.Exp(Math.Abs(x - y)) * Math.Pow((Math.Pow(Math.Tan(z), 2) + 1),x);
            textBox4.Text += Environment.NewLine + ($"U2 = {u2}");

            double v = ((1 + Math.Pow(Math.Sin(x + y), 2)) / Math.Abs(x - ((2 * y) / 1 + Math.Pow(x, 2) * Math.Pow(y, 2)))) * Math.Pow(x, Math.Abs(y)) + Math.Pow(Math.Cos(Math.Atan(1 / 2)), 2);
            textBox4.Text += Environment.NewLine + ($"V = {v}");

            double w = Math.Pow(Math.Abs(Math.Cos(x) - Math.Cos(y)), (1 + 2 * Math.Pow(Math.Sin(y), 2))) * (1 + z + (Math.Pow(z, 2) / 2) + (Math.Pow(z, 3) / 3) + (Math.Pow(z, 4) / 4));
            textBox4.Text += Environment.NewLine + ($"W = {w}");

            double a = Math.Log(Math.Pow(y, (-Math.Sqrt(Math.Abs(x))))) * (x - y / 2) + Math.Pow(Math.Sin(Math.Atan(z)), 2);
            textBox4.Text += Environment.NewLine + ($"a = {a}");

            double b = Math.Sqrt(10 * (Math.Pow(x, 1 / 3) + Math.Pow(x, y + 2))) * (Math.Pow(Math.Asin(z), 2) - Math.Abs(x - y));
            textBox4.Text += Environment.NewLine + ($"B = {b}");

            double sy = 5 * Math.Atan(x) - 1 / 4 * Math.Acos(x) * ((x + 3 * Math.Abs(x - y) + Math.Pow(x, 2)) / Math.Abs(x - y) * z + Math.Pow(x, 2));
            textBox4.Text += Environment.NewLine + ($"Y = {sy}");

            double f = (Math.Exp(Math.Abs(x - y)) * Math.Pow(Math.Abs(x - y), x + y)) / (Math.Atan(x) + Math.Atan(z)) + Math.Pow((Math.Pow(x, 6) + Math.Pow(Math.Log(y), 2)), 1 / 3);
            textBox4.Text += Environment.NewLine + ($"Ф = {f}");
        }
    }
}
