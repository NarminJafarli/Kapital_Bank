using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kapital_Bank
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        decimal bank = 0;
        decimal balans = 100;

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
            label8.Text = "Balans:" + balans.ToString() + "AZN";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal money =Convert.ToDecimal(textBox1.Text);
             
            if(bank<balans)
            {
                label7.Text = "Bankda kifayet qeder mebleg yoxdur";
            }
            else
            {
                if (money < balans)
                {
                    balans = balans - money;
                    label7.Text = "Əməliyyat uğurla həyata keçirildi.";
                    label8.Text = "Balans:" + balans.ToString() + "AZN";
                }
                else
                {
                    label7.Text = "Balansda kifayet qeder mebleg yoxdur ";
                }

            }
            
            
            
            
           ;
        }
    }
}
