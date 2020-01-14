using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            double ugis;
            double svoris;
            double kmi;
            
            string koment;

        private void button2_Click(object sender, EventArgs e)

        {
            if (tbInput3.Text == "" || tbInput4.Text =="")
            {
                MessageBox.Show("Ivesti neteisingi duomenis");
                return;
            }
            if (!double.TryParse(tbInput3.Text, out ugis) ||!double.TryParse(tbInput4.Text, out svoris))
            {
                MessageBox.Show("Ivesti neteisingi duomenis");
                return;
            }


            ugis = double.Parse(tbInput3.Text);
            svoris = double.Parse(tbInput4.Text);
            kmi = svoris / (ugis * ugis);

            

            if (kmi > 30)
            {
                koment = "Asmuo yra nutukes";
                // Console.WriteLine("Asmuo yra nutukes");
                // tbOutput1.Clear();
                //  tbOutput1.Text = ($"Asmuo yra nusilpes ir jo kuno svoris per mazas{(kmi > 18.5)}");

            }
            else if (kmi < 18.5)

            {
                koment = "Asmuo yra nusilpes ir jo kuno svoris per mazas";
                // Console.WriteLine("Asmuo yra nusilpes ir jo kuno svoris per mazas");
            }
            else if ((kmi > 18.5) && (kmi < 25))
            {
                koment = "Idealus kuno mases indeksas";
                // Console.WriteLine("Idealus kuno mases indeksas");
            }
            else if ((kmi > 25) && (kmi < 30))
            {
                koment = "Asmuo antsvori";
                //Console.WriteLine("Asmuo antsvori");
            }
            tbOutput1.Clear();
            tbOutput1.Text = ($"{kmi} {koment}");
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        

        }

        private void tbInput4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbOutput1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

