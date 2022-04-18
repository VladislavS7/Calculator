using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AnalaizerClass
{
    public class Analaizer
    {
        private static int erposition = 0;
        public static string expression = "12+2*((3*4)+(11/5))";
        public static bool ShowMessage = true;
        public Analaizer()
        {
            ContainerOperator.Add_Operators(new Operator("*", 3));
            ContainerOperator.Add_Operators(new Operator("/", 3));
            ContainerOperator.Add_Operators(new Operator("+", 2));
            ContainerOperator.Add_Operators(new Operator("-", 2));
            ContainerOperator.Add_Operators(new Operator("(", 1));
        }
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
            else if (n > 0)
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
        public string Format()
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
                if (expression[i] != ' ')
                    result += expression[i];

                if (op.Contains(expression[i]))
                    ++countNumOp;

                if (Char.IsDigit(expression[i]) && !Char.IsDigit(expression[i + 1]) || op.Contains(expression[i]))
                    result += ' ';
                //else if (!op.Contains(expression[i]) && !Char.IsDigit(expression[i]) && expression[i] != ' ')
                //{
                //    string v = $"&Error 02 at <{i}>";
                //    return v;
                //}
                else if (op.Contains(expression[i]) && op.Contains(expression[i + 1]))
                {
                    string v1 = $"&Error 04 at <{i + 1}>";
                    return v1;
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

            //for (int i = 0; i < result.Length; ++i)
            //{
            //    if (expression[i] == '/' && expression[i + 1] == '0' && expression[i + 2] == ' ')
            //        return "&Error 9";
            //}

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
        public static System.Collections.ArrayList CreateStack(string ss)
        {
            System.Collections.ArrayList list = new System.Collections.ArrayList();
            string input_string = "";
            Stack<string> operators_stack = new Stack<string>();
            string temp;
            int ro;
            int lo;
            foreach (char c in input_string)
            {
                list.Add(c);
            }

            foreach (char c in ss)
            {
                if (Char.IsDigit(c))
                {
                    input_string += c;
                    continue;
                }
                if (c == '+' || c == '-' || c == '*' || c == '/')
                {
                    input_string += " ";
                    if (operators_stack.Count == 0)
                    {
                        operators_stack.Push(Convert.ToString(c));
                        continue;
                    }
                    else if (operators_stack.Count != 0)
                    {
                        if (ContainerOperator.Find_Operator(operators_stack.Peek()).priority < ContainerOperator.Find_Operator(Convert.ToString(c)).priority)
                        {
                            operators_stack.Push(Convert.ToString(c));
                            continue;
                        }
                    }
                    if (operators_stack.Count != 0)
                    {
                        try
                        {
                            while (ContainerOperator.Find_Operator(operators_stack.Peek()).priority >= ContainerOperator.Find_Operator(Convert.ToString(c)).priority)
                            {

                                input_string += operators_stack.Pop();
                            }
                        }
                        catch
                        {

                        }
                        if (operators_stack.Count == 0)
                        {
                            operators_stack.Push(Convert.ToString(c));
                            continue;
                        }
                        else if (operators_stack.Count != 0)
                        {
                            if (ContainerOperator.Find_Operator(operators_stack.Peek()).priority < ContainerOperator.Find_Operator(Convert.ToString(c)).priority)
                            {
                                operators_stack.Push(Convert.ToString(c));
                                continue;
                            }
                        }
                    }
                }
                if (c == '(')
                {

                    operators_stack.Push(Convert.ToString(c));
                }
                if (c == ')')
                {
                    while (operators_stack.Peek() != "(")
                    {
                        input_string += " ";
                        input_string += operators_stack.Pop();
                    }
                    operators_stack.Pop();
                    continue;
                }
            }
            while (operators_stack.Count != 0)
            {
                input_string += " ";
                input_string += operators_stack.Pop();
            }

            foreach (char c in input_string)
            {
                list.Add(Convert.ToString(c));
            }
            return list;
        }
        public string RunEstimate()
            countNumOp += numbers.Length;
            if (countNumOp > 30)
                return "&Error 08";

            return result;
        }
        public static System.Collections.ArrayList CreateStack()
        {
            return new System.Collections.ArrayList();
        }
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
        public string Estimate()
        {
            if (CheckCurrency() == false)
                throw new Exception($"Error 1 at <{erposition}>");

            string result = Format();
            if (result[0] == '&')
                throw new Exception(result);

            expression = result;
            ArrayList stack = CreateStack(result);


            expression = "";
            foreach (var item in stack)
            {
                expression += item.ToString();
            }
            //Console.WriteLine(expression);
            return RunEstimate();
        }
        public static string Estimate()
        {
            if (CheckCurrency() == false)
                throw new Exception($"Error 1 at <{erposition}>");

            string result = Format();
            if(result[0] == '&')
                throw new Exception(result);

            expression = result;
            ArrayList stack = CreateStack();

            expression = stack.ToString();
            return RunEstimate();
        }
    }
}
