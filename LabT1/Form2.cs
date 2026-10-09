using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace LabT1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();  
            f3.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "\tYemen";
            SoundPlayer sPlayer = new SoundPlayer(@"C:\Users\PC\Desktop\مجلد جديد (2)\النشيد_الوطني_اليمني__رددي_أيتها_الدنيا_نشيدي__Yemen_National_Anthem_144p_.wav");
            sPlayer.Play();
           
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "\tSpanish";
            SoundPlayer sPlayer = new SoundPlayer(@"C:\Users\PC\Desktop\مجلد جديد (2)\السلام_الوطني_الإسباني_144p__1.wav");

            sPlayer.Play();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "\tGerman"; 
            SoundPlayer sPlayer = new SoundPlayer(@"C:\Users\PC\Desktop\مجلد جديد (2)\السلام_الوطني_الإسباني_144p_.wav");
            sPlayer.Play();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer sPlayer = new SoundPlayer();
            sPlayer.Stop();
        }
    }
}
