using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {
        string _tmp ;
        char action ;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (input.Text.Length != 0)
            {
                input.Text = input.Text.Remove(input.Text.Length - 1);
            }
            else
            {
                input.Text = "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void MultiplyButton_Clicl(object sender, EventArgs e)
        {
            _tmp = input.Text;
            input.Text = "";
            action = '*';
        }

        private void button12_Click(object sender, EventArgs e)
        {
            _tmp = input.Text;
            input.Text = "";
            action = '/';
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void but1_Click(object sender, EventArgs e)
        {
            
        }

        private void but3_Click(object sender, EventArgs e)
        {
           
        }

        private void but4_Click(object sender, EventArgs e)
        {
            
        }

        private void but2_Click(object sender, EventArgs e)
        {
           
        }

        private void CommaButton_Click(object sender, EventArgs e)
        {
            
           

        }
        
        private void NumericButton_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button button = (Button)sender;
                if (input.Text == "0" && button.Text != ",")
                {
                    input.Text = "";
                }
                else
                {
                    input.Text += button.Text;
                }
            }
            else
            {
                throw new Exception();
            }



        }

        private void but8_Click(object sender, EventArgs e)
        {
           
        }

        private void but5_Click(object sender, EventArgs e)
        {
            
        }

        private void but6_Click(object sender, EventArgs e)
        {
            
        }

        private void But7_Click(object sender, EventArgs e)
        {
            
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            _tmp = input.Text;
            input.Text = "";
            action = '+';

        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            double answer = 0;

            switch (action)
            {
                case '+':
                    answer = Convert.ToDouble(_tmp) + Convert.ToDouble(input.Text);
                    
                    break;
                case '-':
                    double x = Convert.ToDouble(_tmp);
                    double y = Convert.ToDouble(input.Text);
                    answer = x-y;
                    
                    
                    break;
                case '/':
                    answer = Convert.ToDouble(_tmp) / Convert.ToDouble(input.Text);
                   
                    break;

                case '*':
                    answer = Convert.ToDouble(_tmp) * Convert.ToDouble(input.Text);
                    
                    break;


            }
            input.Text =Convert.ToString( answer);


        }

        private void minus_Click(object sender, EventArgs e)
        {
            _tmp = input.Text;
            input.Text = "";
            action = '-';
        }

        private void c_Click(object sender, EventArgs e)
        {
            input.Text = "";
        }
    }
}
