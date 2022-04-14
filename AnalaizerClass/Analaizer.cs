using System;
using System.Collections.Generic;

namespace AnalaizerClass
{
    public class Analaizer
    {
        private static int erposition = 0;
        public static string expression = "";
        public static bool ShowMessage = true;
        public static bool CheckCurrency()
        {
            int n = 0;
            foreach (var item in expression)
            {
                if (item == '(') ++n;
                else if (item == ')') --n;
            }

            if (n == 0)
                return true;
            else if(n > 0)
            {
                erposition = expression.LastIndexOf('(');
                return false;
            }
            else
            {
                erposition = expression.LastIndexOf(')');
                return false;
            }
        }
        //public static string Format() { }
        //public static System.Collections.ArrayList CreateStack()
        //{

        //}
        public static string RunEstimate()
        {
            string[] expTokens = expression.Split(' ');
            Stack<decimal> stack = new Stack<decimal>();
            decimal number = decimal.Zero;

            foreach (string token in expTokens)
            {
                if (decimal.TryParse(token, out number))
                {
                    stack.Push(number);
                }
                else
                {
                    switch (token)
                    {
                        case "*":
                            {
                                stack.Push(stack.Pop() * stack.Pop());
                                break;
                            }
                        case "/":
                            {
                                number = stack.Pop();
                                stack.Push(stack.Pop() / number);
                                break;
                            }
                        case "+":
                            {
                                stack.Push(stack.Pop() + stack.Pop());
                                break;
                            }
                        case "-":
                            {
                                number = stack.Pop();
                                stack.Push(stack.Pop() - number);
                                break;
                            }
                        default:
                            return "error";
                            break;
                    }
                }
            }

            return stack.Pop().ToString();
        }
        //public static string Estimate() { }
    }
}
