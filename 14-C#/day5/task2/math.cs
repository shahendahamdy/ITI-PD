using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class math
    {
        /// Add, Subtract, Multiply, and Divide
        public double add(double x, double y) { return x + y; }
        public double Subtract(double x, double y) { return x - y; }
        public double Multiply(double x, double y) { return x * y; }
        public double Divide(double x, double y)
        {
            try
            {
                return x / y;
            }
            catch (Exception e) { return -1; }


        }
    }
}