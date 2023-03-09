using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class _3Dpoint
    {
        int x;
        int y;
        int z;

        public _3Dpoint() { 

        }
        public _3Dpoint(int x)
        {
            this.x = x;
        }
       public _3Dpoint(int x, int y): this(x)
        {
            this.y = y;
        }
        public _3Dpoint(int x, int y, int z) : this(x, y)
        {
            this.z = z;
        }
        public override string ToString()
        {
            return $" Point Coordinates:   ({x},{y},{z})";
        }
        ///Try to override the Equals Function (from base Object)
        public override bool Equals( Object p)
        {
            if (p is _3Dpoint)
            {
                _3Dpoint temp = (_3Dpoint)p;

                return temp.x == x && temp.y == y && temp.z == z;
            }
            else return false;
        }


        public int X { set { x = value; } get { return x; } }     
        public int Y { set { y = value; } get { return y; } }     
        public int Z { set { z = value; } get { return z; } }     

    }
}
