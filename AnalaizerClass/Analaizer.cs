using System;

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
        //public static string RunEstimate() { }
        //public static string Estimate() { }
    }
}
