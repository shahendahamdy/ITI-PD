using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class math2
    {
        /// Add, Subtract, Multiply, and Divide
        public static double add(double x, double y) { return x + y; }
        public static double Subtract(double x, double y) { return x - y; }
        public static double Multiply(double x, double y) { return x * y; }
        public static double Divide(double x, double y)
        {
            try
            {
                return x / y;
            }
            catch (Exception e) { return -1; }


        }
    }
}
