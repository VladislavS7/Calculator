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


        public Form1()
        {
            InitializeComponent();
        }
       
        public Form1(string v)
        {
            InitializeComponent();
            this.text_Expression.Text = v;
            this.Load += Form1_Load;

        }

        private void btn_OpenArc_Click(object sender, EventArgs e)
        {
            List<char> digits = new List<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', ')'};
            if(digits.Contains(text_Expression.Text[text_Expression.Text.Length - 1]))
            {
                text_Expression.Text += "*(";
            }
            else
            {
                text_Expression.Text += "(";
            }
            
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

        //Крапка
        private void btn_mod_Click(object sender, EventArgs e)
        {
            if(text_Expression.Text.Length == 0)
            {
                return;
            }
            string tmp = string.Empty;
            List<char> digits = new List<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            char s;
            for (int i = text_Expression.Text.Length-1; i >= 0; i--)
            {
                s = text_Expression.Text[i];
                if (!digits.Contains(s))
                {
                    tmp = text_Expression.Text.Substring(i);
                    if (tmp.Length >= 2) 
                    if (!tmp.Contains('.') && digits.Contains(tmp[1]))
                    {
                        text_Expression.Text += ".";
                        
                    }
                    return;
                }
                else if(i == 0)
                {
                    text_Expression.Text += ".";
                }
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
            try
            {
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
            catch { }
        }


        //Додати в пам'ять
        private void btn_M_Click(object sender, EventArgs e)
        {

            btn_equal_Click(sender, e);

            if (text_Resualt.Text.Contains("Error"))
            {
                MessageBox.Show("Неможливо перетворити до числа");
                return;
            }
            else
            {
                
                if (text_Resualt.Text.Length > 0)
                {
                    Memory = Convert.ToDouble(text_Resualt.Text);// Число з результату
                }
            }
        }

        //Використати з пам'яті
        private void btn_MR_Click(object sender, EventArgs e)
        {
            if(Memory != 0)
            {
                string tmp = string.Empty;
                switch (text_Expression.Text[text_Expression.Text.Length - 1])
                {
                    case '+':
                        text_Expression.Text += Memory;
                        break;
                    case '-':
                        tmp = text_Expression.Text.Remove(text_Expression.Text.Length - 1);
                        tmp += "+" + Memory;
                        text_Expression.Text = tmp;
                        break;
                    case '*':
                        tmp = text_Expression.Text.Remove(text_Expression.Text.Length - 1);
                        tmp += "+" + Memory;
                        text_Expression.Text = tmp;
                        break;
                    case '/':
                        tmp = text_Expression.Text.Remove(text_Expression.Text.Length - 1);
                        tmp += "+" + Memory;
                        text_Expression.Text = tmp;
                        break;
                    case '(':
                        text_Expression.Text += Memory;
                        break;
                    case ')':
                        text_Expression.Text += "+" + Memory;
                        break;
                    default:
                        text_Expression.Text += "+" + Memory;
                        break;
                }
                
            }
        }

        //Обнудення пам'яті
        private void btn_MC_Click(object sender, EventArgs e)
        {
            Memory = 0;
        }

        //Обробка натискання на кнопку з клавіатури
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btn_equal.TabIndex = 0;
            this.btn_equal.Click += new EventHandler(btn_equal_Click);
            this.Controls.Add(btn_equal);
            btn_equal.PerformClick();
        }
    }
}
