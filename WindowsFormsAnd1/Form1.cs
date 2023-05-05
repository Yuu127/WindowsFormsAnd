using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAnd1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            string soA = this.textBox1.Text.Trim();
            int A = int.Parse(soA);

            string soB = this.textBox2.Text.Trim();
            int B = int.Parse(soB);

            var kq = A + B;

            this.label3.Text = kq.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("...");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ten = this.textBox3.Text.Trim();
            MessageBox.Show($"Chào {ten}");
        }
    }
}
