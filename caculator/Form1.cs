using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float a = float.Parse(textBox1.Text);
                float b = float.Parse(textBox2.Text);
                float Cong = (a + b);
                textBox3.Text = Cong.ToString();
            }
            catch
            {
                MessageBox.Show(" nhap lai thong tin");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                float a = float.Parse(textBox1.Text);
                float b = float.Parse(textBox2.Text);
                float Tru = (a - b);
                textBox3.Text = Tru.ToString();
            }
            catch
            {
                MessageBox.Show(" nhap lai thong tin");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                float a = float.Parse(textBox1.Text);
                float b = float.Parse(textBox2.Text);
                float Nhan = (a * b);
                textBox3.Text = Nhan.ToString();
            }
            catch
            {
                MessageBox.Show(" nhap lai thong tin");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                float a = float.Parse(textBox1.Text);
                float b = float.Parse(textBox2.Text);
                float Chia = (a / b);
                textBox3.Text = Chia.ToString();
            }
            catch
            {
                MessageBox.Show(" nhap lai thong tin");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
