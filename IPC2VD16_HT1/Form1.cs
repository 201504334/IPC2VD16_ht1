using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPC2VD16_HT1
{
    public partial class Form1 : Form
    {

        double a;
        double b;
        double c;
        double res;


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = double.Parse(texta.Text);
            b = double.Parse(textb.Text);
            c = double.Parse(textc.Text);
            res = 0;

            res = Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 3);
            textres.Text = res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
a = double.Parse(texta.Text);
            b = double.Parse(textb.Text);
            c = double.Parse(textc.Text);
            res = 0;

            res = a * b * c - a * c;
            textres.Text = res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
a = double.Parse(texta.Text);
            b = double.Parse(textb.Text);
            c = double.Parse(textc.Text);
            res = 0;

            res = (a/b) -(b/c);
            textres.Text = res.ToString();
			
			textres.Text = textres.Text + "_201504334";

        }

        private void button4_Click(object sender, EventArgs e)
        {
a = double.Parse(texta.Text);
            b = double.Parse(textb.Text);
            c = double.Parse(textc.Text);
            res = 0;

            res = Math.Pow(b, 0.5) - Math.Pow(c, 2) + a;
            textres.Text = res.ToString();
        }
    }
}
