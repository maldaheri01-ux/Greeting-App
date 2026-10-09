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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text =" \t صباح الخير";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\PC\Desktop\مجلد جديد (2)\كيف_تنطق_صباح_الخير_باللغة_العربية__How_to_pronounce_good_morning_in_Arabic_360p_.wav");
            splayer.Play();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "\tBuenosdias  ";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\PC\Desktop\مجلد جديد (2)\كيف_تقول_باللغه_الاسبانيه_صباح_الخير_360p_.wav");
            splayer.Play();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "\tGuten Morgen    ";
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\PC\Desktop\مجلد جديد (2)\Good_morning_in_German_صباح_الخير_باللغة_الالمانية_360p_.wav");
            splayer.Play();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2= new Form2();
            f2.ShowDialog(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SoundPlayer sPlayer = new SoundPlayer();
            sPlayer.Stop();
        }
    }
}
