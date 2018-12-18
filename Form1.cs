using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace lab1_mayorov
{
    public partial class Form1 : Form
    {
        [DllImport(@"C:\Users\user\source\repos\lab11\Debug\Project1.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern double Add(double x, double y);
        [DllImport(@"C:\Users\user\source\repos\lab11\Debug\Project1.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Prime(ulong number);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string t1 = textBox1.Text;
            string t2 = textBox2.Text;
            double x = Convert.ToDouble(t1);
            double y = Convert.ToDouble(t2);
            double res = Add(x, y);
            textBox3.Text = res.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t = textBox4.Text;
            if (isPrime(Convert.ToUInt32(t)) == 1)
                textBox4.Text = " простое ";
            else
                textBox4.Text = " не простое ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int l = 0;
            for (ulong i = 2; i <= 100; i++)
            {
                if (isPrime(i) == 1)
                    l++;

                chart1.Series[0].Points.AddXY(i, l);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}

