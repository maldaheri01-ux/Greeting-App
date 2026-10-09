using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabT1
{
    public partial class Form4 : Form
    {
        public int ClassA = 450;
        public int ClassB = 400;
         public int ClassC = 350;

        public Form4()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;

            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text) * ClassA;
            textBox6.Text = "    " + num1.ToString();
            int num2 = int.Parse(textBox2.Text) * ClassB;
            textBox5.Text = "    " + num2.ToString();
            int num3 = int.Parse(textBox3.Text) * ClassC;
            textBox4.Text = "    " + num3.ToString();
            int Total = num1 + num2 + num3;
            textBox7.Text ="    "+ Total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
