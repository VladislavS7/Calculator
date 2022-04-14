using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double Memory;
        private string _fix;
        private double _nik;
        private readonly string _undoArrow = char.ConvertFromUtf32(0x00002190);


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

        internal static bool CharIsAnOperator(string userInput)
        {
            return userInput.Equals("+") ||
                   userInput.Equals("-") ||
                   userInput.Equals("*") ||
                   userInput.Equals("/") ||
                   userInput.Equals("%");
        }

        private bool ParenthesesAmountIsEqual(string userInput)
        {
            int leftParenthesesAmount = 0;
            int rightParenthesesAmount = 0;

            foreach (var item in userInput)
            {
                if (item.Equals('('))
                    leftParenthesesAmount++;
                else if (item.Equals(')'))
                    rightParenthesesAmount++;
            }

            return leftParenthesesAmount == rightParenthesesAmount;
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            //Обчислення

            if (CharIsAnOperator(text_Expression.Text[text_Expression.Text.Length - 1].ToString()) || (text_Expression.Text[text_Expression.Text.Length - 1].ToString().Equals(".")) || (text_Expression.Text[text_Expression.Text.Length - 1].ToString().Equals("(")))
            {
                MessageBox.Show(@"Error03! Please enter a valid character. 
                    The last character of the equation cannot be an operator, a decimal separator, or a left parenthesis!",
                    Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ParenthesesAmountIsEqual(text_Expression.Text))
            {
                MessageBox.Show(@"Error01!!Please enter a valid character. 
                The number of left and right parentheses is not the same!", 
                Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _fix = text_Expression.Text;

            try
            {
                Onp onp = new Onp(_fix);
                _nik = onp.PostfixEvaluation(onp.InfixToPostfix());
            }
            catch
            {
                MessageBox.Show(@"A problem occured!", @"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            text_Resualt.Text = _nik.ToString(CultureInfo.InvariantCulture).Replace(',', '.');

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
            //if(e.KeyCode == Keys.Escape)
            //{
            //    this.Close();
            //}
            //if(e.KeyCode == Keys.Enter)
            //{
            //    MessageBox.Show("Обчислення виразу");
            //}

            if (e.KeyCode == Keys.Delete)
                btn_C.PerformClick();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    btn_0.PerformClick();
                    break;
                case "1":
                    btn_1.PerformClick();
                    break;
                case "2":
                    btn_2.PerformClick();
                    break;
                case "3":
                    btn_3.PerformClick();
                    break;
                case "4":
                    btn_4.PerformClick();
                    break;
                case "5":
                    btn_5.PerformClick();
                    break;
                case "6":
                    btn_6.PerformClick();
                    break;
                case "7":
                    btn_7.PerformClick();
                    break;
                case "8":
                    btn_8.PerformClick();
                    break;
                case "9":
                    btn_9.PerformClick();
                    break;
                case "+":
                    btn_plus.PerformClick();
                    break;
                case "-":
                    btn_sub.PerformClick();
                    break;
                case "*":
                    btn_mul.PerformClick();
                    break;
                case "/":
                    btn_div.PerformClick();
                    break;
                case "(":
                    btn_OpenArc.PerformClick();
                    break;
                case ")":
                    btn_CloseArc.PerformClick();
                    break;
                case "=":
                    btn_equal.PerformClick();
                    break;
            }

            if (e.KeyChar.Equals((char)Keys.Enter))
                btn_equal.PerformClick();

            if (e.KeyChar.Equals((char)Keys.Back))
                btn_C.PerformClick();
        }

    }
}
