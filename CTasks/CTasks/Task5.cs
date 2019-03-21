using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTasks
{
    public class Task5
    {
        public struct Calculator
        {

            public static double sum(double x, double y)
            {
                return x + y;
            }

            public static double sub(double x, double y)
            {
                return x - y;
            }
            public static double mult(double x, double y)
            {
                return x * y;
            }
            public static double div(double x, double y)
            {
                return x / y;
            }
        }
    }
}
