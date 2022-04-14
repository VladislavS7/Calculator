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

        public static double Add(double a, double b)
        {
            checked
            {
                return a + b;
            }
        }
        public static double Sub(double a, double b)
        {
            checked
            {
                return a - b;
            }
        }
        public static double Mult(double a, double b)
        {
            checked
            {
                return a * b;
            }
        }
        public static double Div(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException();
            else
                return a / b;
        }
        public static double Mod(double a, double b)
        {
            checked
            {
                return a % b;
            }
        }
        public static double ABS(double a)
        {
            if (a < 0.0)
            {
                return -a;
            }
            return a;
        }
        public static double IABS(double a)
        {
            if (a > 0.0)
            {
                return a;
            }
            return -a;
        }
    }
}
