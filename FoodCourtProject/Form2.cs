using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textBox4.Visible = true;
                textBox4.Text = "";
                label5.Visible = true;
            }

            else if (radioButton1.Checked == true)
            {
                textBox4.Visible = false;
                label5.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int withsugartea;
            int withoutsugartea;
            int hotcoffee;
            int coldcoffee;
            int totalamt;
            int snacks;
            int Burger;
            int pizza;
            Burger = 45;
            snacks = 15;
            pizza = 60;
            withsugartea = 5;
            withoutsugartea = 8;
            hotcoffee = 10;
            coldcoffee = 20;
            int totalamttea = 0;
            int totalamtcoffee = 0;
            int totalamtsnacks = 0;
            int totalpizza = 0;
            int totalburger = 0;

            if (checkBox1.Checked == true)
            {
                totalamttea = int.Parse(textBox1.Text) * withoutsugartea;
            }
            if (checkBox1.Checked == false)
            {
                totalamttea = int.Parse(textBox1.Text) * withsugartea;
            }

            if (checkBox2.Checked == true)
            {
                totalamtcoffee = int.Parse(textBox2.Text) * coldcoffee;
            }

            if (checkBox2.Checked == false)
            {
                totalamtcoffee = int.Parse(textBox2.Text) * hotcoffee;

            }

            totalamtsnacks = int.Parse(textBox5.Text) * snacks;
            totalburger = int.Parse(textBox6.Text) * Burger;
            totalpizza = int.Parse(textBox7.Text) * pizza;


            totalamt = totalamttea + totalamtcoffee + totalamtsnacks + totalburger + totalpizza;


            if (radioButton1.Checked == true)
            {
                textBox3.Text = totalamt.ToString();
                MessageBox.Show("Payment recieved in cash! Thank You!");
            }

            if (radioButton2.Checked == true)
            {
                if (textBox4.Text == " ")
                {
                    textBox3.Text = " ";
                    MessageBox.Show("Please enter a credit card number.");
                }

                else
                {
                    textBox3.Text = totalamt.ToString();
                    MessageBox.Show("Payment Recieved from your credit card! Thank You!");
                }
            }
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("please select the payment mode");
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       





        }
    }
        
       
    

