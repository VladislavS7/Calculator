using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double Memory;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_OpenArc_Click(object sender, EventArgs e)
        {
                text_Expression.Text += "(";
        }

        private void btn_CloseArc_Click(object sender, EventArgs e)
        {
                text_Expression.Text += ")";
        }

        private void btn_Backspace_Click(object sender, EventArgs e)
        {
            if(text_Expression.Text.Length > 0)
            text_Expression.Text = text_Expression.Text.Remove(text_Expression.Text.Length - 1);
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            text_Expression.Text = "";
            text_Resualt.Text = "";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            text_Expression.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            text_Expression.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            text_Expression.Text += "3";
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            if (text_Expression.Text.Length == 0)
                return;

            if(text_Expression.Text[text_Expression.Text.Length - 1] != '/' && text_Expression.Text[text_Expression.Text.Length - 1] != '*' &&
                text_Expression.Text[text_Expression.Text.Length - 1] != '+' && text_Expression.Text[text_Expression.Text.Length - 1] != '+')
            {
                text_Expression.Text += "/";
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            text_Expression.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            text_Expression.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            text_Expression.Text += "6";
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            if (text_Expression.Text.Length == 0)
                return;

            if (text_Expression.Text[text_Expression.Text.Length - 1] != '/' && text_Expression.Text[text_Expression.Text.Length - 1] != '*' &&
                text_Expression.Text[text_Expression.Text.Length - 1] != '+' && text_Expression.Text[text_Expression.Text.Length - 1] != '+')
            {
                text_Expression.Text += "*";
            }
            
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            text_Expression.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            text_Expression.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            text_Expression.Text += "9";
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            if (text_Expression.Text.Length == 0)
                return;

            if (text_Expression.Text[text_Expression.Text.Length - 1] != '/' && text_Expression.Text[text_Expression.Text.Length - 1] != '*' &&
                text_Expression.Text[text_Expression.Text.Length - 1] != '+' && text_Expression.Text[text_Expression.Text.Length - 1] != '+')
            {
                text_Expression.Text += "-";
            }
        }

        private void btn_plus_minus_Click(object sender, EventArgs e)
        {
            if (text_Expression.Text.Length != 0)
            {
                string tmp = text_Expression.Text;
                if (text_Expression.Text[0] != '-')
                {
                    text_Expression.Text = "-" + tmp;
                }
                else
                {
                    tmp = tmp.Remove(0, 1);
                    text_Expression.Text = tmp;
                }
            }
            else
            {
                text_Expression.Text += "-";
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            text_Expression.Text += "0";
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (text_Expression.Text.Length == 0)
                return;

            if (text_Expression.Text[text_Expression.Text.Length - 1] != '/' && text_Expression.Text[text_Expression.Text.Length - 1] != '*' &&
                text_Expression.Text[text_Expression.Text.Length - 1] != '+' && text_Expression.Text[text_Expression.Text.Length - 1] != '+')
            {
                text_Expression.Text += "+";
            }
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            if (text_Expression.Text[text_Expression.Text.Length - 1] != '|')
            {
                text_Expression.Text += "|";
            }
        }

        
        private void btn_equal_Click(object sender, EventArgs e)
        {
            //Обчислення
            MessageBox.Show("Обчислення виразу");
        }


        //Додати в пам'ять
        private void btn_M_Click(object sender, EventArgs e)
        {

            //
            //Потрібно додати число до пам'яті
            //

            if (text_Resualt.Text.Contains("Error"))
            {
                MessageBox.Show("Неможливо перетворити до числа");
                return;
            }
            else
            {
                double result = 0;
                if (text_Resualt.Text.Length > 0)
                {
                    result = Convert.ToDouble(text_Resualt.Text);// Число з результату
                }
                
            }
        }

        //Використати з пам'яті
        private void btn_MR_Click(object sender, EventArgs e)
        {
            text_Expression.Text += "+" + Memory;
        }

        //Обнудення пам'яті
        private void btn_MC_Click(object sender, EventArgs e)
        {
            Memory = 0;
        }

        //Обробка натискання на кнопки з клавіатури
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if(e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Обчислення виразу");
            }
        }
    }
}
