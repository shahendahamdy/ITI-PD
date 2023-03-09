using System;
using System.Diagnostics;

namespace Task3
{
     class Program
    {
        //1 20 300 4000 50000 600000
        //1-9 -->1
        //1-99 -->20
        //1-999 -->300 
        //1-9999 -->4000
        // num+1/10 + Length
        public int fun(int num)
        {
            string x = num.ToString();
            return x.Length * (num + 1) / 10;
        }
        static void Main(string[] args)
        {
            string temp;
            int cntr=0;
            var timer = new Stopwatch();
            timer.Start();

            //B: Run stuff you want timed
            
            
            for (int i = 1; i <= 99999999; i++)
            {
                temp= i.ToString();
                for(int j = 0; j < temp.Length; j++)
                {
                    if (temp[j] == '1') cntr++;

                }
            }
            Console.WriteLine(cntr);

            timer.Stop();

            Console.WriteLine(timer.Elapsed.ToString());
            //---------------------------------------
            timer = new Stopwatch();
            timer.Start();

            //B: Run stuff you want timed
            cntr= 0;
            int num, rem;
            for (int i = 1; i <= 99999999; i++)
            {
                num = i;
                while (num >= 10)
                {
                    rem= num % 10;
                    if (rem == 1) { cntr++; }
                    num /= 10;
                }
                if (num == 1) { cntr++; }

            }
            Console.WriteLine(cntr);

            timer.Stop();
            Console.WriteLine(timer.Elapsed.ToString());

            //-------------------------------------------------------------------------------------------
            timer = new Stopwatch();
            timer.Start();

            //B: Run stuff you want timed

            int x = 99999999;
            Program program = new Program();
            int ans =program.fun(x);


            Console.WriteLine(ans);

            timer.Stop();
            Console.WriteLine(timer.Elapsed.ToString());

        }
    }
}