using System;
using System.Collections.Generic;
using System.Text;

namespace AnalaizerClass
{
    public class Operator
    {
        public int priority;
        public string symbol;

        public Operator(string symbol, int priority)
        {
            this.priority = priority;
            this.symbol = symbol;
        }
    }
    public class ContainerOperator
    {
        public static List<Operator> operators = new List<Operator>();
        public static void Add_Operators(Operator op)
        {
            operators.Add(op);
        }
        public static Operator Find_Operator(string s)
        {
            foreach (var el in operators)
            {
                if (el.symbol == s)
                {
                    return el;
                }
            }
            return null;
        }
    }
}
