using CalcClasss;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Onp
    {
        private readonly string _userInput;

        public Onp(string userInput)
        {
            _userInput = userInput;
        }

        public Queue<string> InfixToPostfix()
        {
            StringBuilder postfixQueueCandidate = new StringBuilder();
            Stack<char> specialTokensStack = new Stack<char>();
            Queue<string> postfixQueue = new Queue<string>();
            string infix = InfixConversion(_userInput);

            foreach (char item in infix)
            {
                if (Char.IsNumber(item) || item.Equals('.'))
                    postfixQueueCandidate.Append(item);
                else
                {
                    if (postfixQueueCandidate.Length != 0)
                    {
                        postfixQueue.Enqueue(postfixQueueCandidate.ToString());
                        postfixQueueCandidate.Clear();
                    }

                    if (item.Equals('('))
                    {
                        specialTokensStack.Push(item);
                        continue;
                    }

                    if (item.Equals(')'))
                    {
                        while (!specialTokensStack.Peek().Equals('('))
                        {
                            postfixQueue.Enqueue(specialTokensStack.Pop().ToString());
                        }
                        specialTokensStack.Pop();
                        continue;
                    }
                    if (specialTokensStack.Count() == 0 || specialTokensStack.Peek().Equals('('))
                        specialTokensStack.Push(item);
                    else
                    {
                        if (TokenPriorityLevel(item) > TokenPriorityLevel(specialTokensStack.Peek()))
                            specialTokensStack.Push(item);
                        else
                        {
                            while (specialTokensStack.Count() != 0 && (TokenPriorityLevel(item) <= TokenPriorityLevel(specialTokensStack.Peek())))
                            {
                                postfixQueue.Enqueue(specialTokensStack.Pop().ToString());
                            }
                            specialTokensStack.Push(item);
                        }
                    }
                }
            }
            if (postfixQueueCandidate.Length != 0)
                postfixQueue.Enqueue(postfixQueueCandidate.ToString());

            while (specialTokensStack.Count() != 0)
                postfixQueue.Enqueue(specialTokensStack.Pop().ToString());

            return postfixQueue;
        }

        public double PostfixEvaluation(Queue<string> postfix)
        {
            double x1 = 0, x2 = 0;
            Stack<double> result = new Stack<double>();

            while (postfix.Count != 0)
            {
                var temp = postfix.Dequeue();

                if (temp.Equals("+") || temp.Equals("-") || temp.Equals("*") || temp.Equals("/") || temp.Equals("%"))
                {
                    try
                    {
                        x2 = result.Pop();
                        x1 = result.Pop();
                    }
                    catch
                    {
                        Console.WriteLine(@"stack is empty");
                    }
                    switch (temp)
                    {
                        case "+":
                            result.Push(CalcClass.Add(x1,x2));
                            break;
                        case "-":
                            result.Push(CalcClass.Sub(x1, x2));
                            break;
                        case "*":
                            result.Push(CalcClass.Mult(x1, x2));
                            break;
                        case "/":
                            result.Push(CalcClass.Sub(x1, x2));
                            break;
                        case "%":
                            result.Push(CalcClass.Mod(x1, x2));
                            break;
                    }
                }
                else
                    result.Push(double.Parse(temp, System.Globalization.CultureInfo.InvariantCulture));
            }

            return Convert.ToDouble(result.Pop());
        }

        private int TokenPriorityLevel(char token)
        {
            Dictionary<char, int> priorityDict = new Dictionary<char, int> { { '(', 0 }, { '+', 1 }, { '-', 1 }, { '*', 2 }, { '/', 2 }, { '%', 2 } };
            return (priorityDict[token]);
        }

        private string InfixConversion(string userInput)
        {

            ArrayList arrayList = new ArrayList(userInput.ToCharArray());

            if (arrayList[0].Equals('-') && Char.IsNumber((char)arrayList[1]))
            {
                arrayList.Insert(0, 0);
                arrayList.Insert(0, '(');

                for (int i = 3; i < arrayList.Count - 1; i++)
                {
                    if (Form1.CharIsAnOperator(arrayList[i].ToString()))
                    {
                        arrayList.Insert(i, ')');
                        break;
                    }
                }
            }

            if (arrayList[0].Equals('-') && arrayList[1].Equals('('))
                arrayList.Insert(0, 0);

            for (int i = 0; i < arrayList.Count - 3; i++)
            {
                if (arrayList[i].Equals('(') && arrayList[i + 1].Equals('-') && !Form1.CharIsAnOperator(arrayList[i + 2].ToString()))
                    arrayList.Insert(i + 1, 0);
            }

            StringBuilder infixReady = new StringBuilder();

            foreach (var item in arrayList)
                infixReady.Append(item);

            return infixReady.ToString();
        }
    }
}