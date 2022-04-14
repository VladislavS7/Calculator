using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcClasss
{
    public class CalcClass
    {
        private static string _lastError = "";
        public static string lastError;

        public static double Add(long a, long b)
        {
            checked
            {
                return a + b;
            }
        }
        public static double Sub(long a, long b)
        {
            checked
            {
                return a - b;
            }
        }
        public static double Mult(long a, long b)
        {
            checked
            {
                return a * b;
            }
        }
        public static double Div(long a, long b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            else
                return a / b;
        }
        public static double Mod(long a, long b)
        {
            checked
            {
                return a % b;
            }
        }
        public static double ABS(long a)
        {
            if (a < 0.0)
            {
                return -a;
            }
            return a;
        }
        public static double IABS(long a)
        {
            if (a > 0.0)
            {
                return a;
            }
            return -a;
        }
    }
}
