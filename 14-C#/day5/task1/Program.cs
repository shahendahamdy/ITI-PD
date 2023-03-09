using System.Drawing;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            int []p =new int[3];
            bool b=false;
            _3Dpoint[]pnt= new _3Dpoint[2];
            pnt[0] = new _3Dpoint();
            pnt[1] = new _3Dpoint();
            for (int i = 1; i <= 2; i++)
            {
                b = false;

                Console.WriteLine("Enter point " + i);
                for (int j = 1; j <= 3; j++)
                {
                    do
                    {
                        Console.WriteLine("Enter p " + j);
                        b = int.TryParse(Console.ReadLine(), out p[j-1]);
                    } while (!b);
                }
               pnt[i-1].X = p[0];
                pnt[i-1].Y = p[1];
                pnt[i - 1].Z = p[2];

            }
            ///printing the 2 points
            Console.WriteLine(pnt[0].ToString()); ///print point 1
            Console.WriteLine(pnt[1].ToString());///print point 2
           
            ///If(P1 == P2) Does it work properly? 
            Console.WriteLine(pnt[0] == pnt[1]); ///false compare ref
            ///equals override
            Console.WriteLine(pnt[0].Equals(pnt[1]));///true compare ref

        }
    }
}