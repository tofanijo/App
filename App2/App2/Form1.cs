using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App2
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime datetoday;

            datetoday = DateTime.Now;

            if (textBox2.Text == "")
            {
                MessageBox.Show("Vardas negali buti tuscias");
                return;
            }
            vardasBox1.Text = $"Sveikas {textBox2.Text}{datetoday}";
            vardasBox1.AppendText("\r\nMalonu tave matyti");

        }
    }
}
