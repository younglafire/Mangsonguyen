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
        }
    }
}
