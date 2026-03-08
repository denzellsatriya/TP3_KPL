using System;
using System.Windows.Forms;

namespace TP_MODUL3_103022400034
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) 
        { 
            label1.Text += "1"; 
        }
        private void button2_Click(object sender, EventArgs e) 
        { 
            label1.Text += "2"; 
        }
        private void button3_Click(object sender, EventArgs e) 
        { 
            label1.Text += "3"; 
        }
        private void button4_Click(object sender, EventArgs e) 
        { 
            label1.Text += "4"; 
        }
        private void button5_Click(object sender, EventArgs e) 
        { 
            label1.Text += "5"; 
        }
        private void button6_Click(object sender, EventArgs e) 
        { 
            label1.Text += "6"; 
        }
        private void button7_Click(object sender, EventArgs e) 
        { 
            label1.Text += "7"; 
        }
        private void button8_Click(object sender, EventArgs e) 
        { 
            label1.Text += "8"; 
        }
        private void button9_Click(object sender, EventArgs e) 
        { 
            label1.Text += "9"; 
        }
        private void button11_Click(object sender, EventArgs e) 
        { 
            label1.Text += "0"; 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text += "+";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                string[] angkaInput = label1.Text.Split('+');
                long hasil = 0;

                foreach (string s in angkaInput)
                {
                    if (!string.IsNullOrWhiteSpace(s))
                    {
                        hasil += long.Parse(s);
                    }
                }

                label1.Text = hasil.ToString();
            }
            catch
            {
                label1.Text = "Error";
            }
        }
    }
}