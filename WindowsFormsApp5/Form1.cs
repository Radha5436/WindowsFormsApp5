using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();

        }
    }
}
