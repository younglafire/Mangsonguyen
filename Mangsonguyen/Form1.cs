using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mangsonguyen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.textBox_c.Enabled = false;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                this.textBox_c.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Vui lòng chọn một trong hai phương thức tính toán!");
            }
            else if (!double.TryParse(this.textBox_a.Text, out a) || a == 0)
            {
                MessageBox.Show("Vui lòng nhập số khác 0 cho hệ số a!");
                return;
            }
            else if (!double.TryParse(this.textBox_b.Text, out b))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho hệ số b!");
                return;
            }
            else if (radioButton1.Checked)
            {
                double kq = Math.Round(-b / a, 2);
                this.textBox_kq.Text = "Phuong trinh co nghiem: " + kq.ToString();
            }

            else
            {
                double c;
                if (!double.TryParse(this.textBox_c.Text, out c))
                {
                    MessageBox.Show("Vui lòng nhập số hợp lệ cho hệ số c!");
                    return;
                }
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    this.textBox_kq.Text = "Phuong trinh vo nghiem";
                }
                else if (delta == 0)
                {
                    double kq = Math.Round(-b/ (2 * a), 2);
                    this.textBox_kq.Text = "Phuong trinh co nghiem kep: " + kq.ToString();
                }
                else // Nghiem binh thuong
                {
                    double kq1, kq2;
                    kq1 = Math.Round((-b + Math.Sqrt(delta)) / (2 * a), 2);
                    kq2 = Math.Round((-b - Math.Sqrt(delta)) / (2 * a), 2);
                }

            }
            
        }

        private void textBox_kq_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
