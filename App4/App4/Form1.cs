using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Padaryti įvedimo langą „skaičius“
            //Mygtuko paspaudimu parodyti ar tai
            //lyginis ar nelyginis skaičius
            //Pvz.: 333 yra nelyginis skaičius
            

            if (textBox1.Text == "")
            {
                MessageBox.Show("Langelis negali buti tuscias");
                return;
            }
            try
            {
                int skaicius = (int.Parse(textBox1.Text));
                if(skaicius % 2 != 0)
                {
                    textBox2.Text = $"{textBox1.Text} yra nelyginis skaicius";
                }
                else
                {
                    textBox2.Text = $"{textBox1.Text} yra lyginis skaicius";
                }
            }
            catch
            {
                MessageBox.Show("Ivesti neteisingi duomenis");
            }



            
        }
    }
}
