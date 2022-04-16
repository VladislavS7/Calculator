﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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
        public static string Format()
        {
            string result = "";
            string op = "*/+-";
            int countNumOp = 0;
       
            if (op.Contains(expression[expression.Length - 1])) 
                return "&Error 05";
            if (expression.Length > 65536)
                return "&Error 07";

            
            for (int i = 0; i < expression.Length; ++i)
            {
                if(expression[i] != ' ')
                    result += expression[i];

                if (op.Contains(expression[i]))
                    ++countNumOp;

                if (Char.IsDigit(expression[i]) && !Char.IsDigit(expression[i + 1]) || op.Contains(expression[i]))
                    result += ' ';
                else if (!op.Contains(expression[i]) && !Char.IsDigit(expression[i]) && expression[i] != ' ')
                    return new string($"&Error 02 at <{i}>");
                else if (op.Contains(expression[i]) && op.Contains(expression[i + 1]))
                    return new string($"&Error 04 at <{i + 1}>");
            }

            for(int i = 0; i<result.Length; ++i)
            {
                if (expression[i] == '/' && expression[i + 1] == '0' && expression[i + 2] == ' ')
                    return "&Error 9";
            }

            string[] numbers = Regex.Split(expression, @"\D+");
            foreach (string value in numbers)
            {
                if (!string.IsNullOrEmpty(value))
                {
                    int i = int.Parse(value);
                    if (i <= -2147483648 || i >= 2147483647)
                        return "&Error 6";
                }
            }

            countNumOp += numbers.Length;
            if (countNumOp > 30)
                return "&Error 08";

            return result;
        }
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
