﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //Paspaudus mygtuką išvesti savo vardą
            //10 kartų

            for (int i = 0; i < 10; i++)
            {
                textBox2.AppendText("\r\nRomanas");
            }
           
            
        }
    }
}
