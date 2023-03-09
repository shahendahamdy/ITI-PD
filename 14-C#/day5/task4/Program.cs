namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Duration D1 = new Duration(1, 59, 15);
            Console.WriteLine(D1.ToString());
            // Output: Hours: 1, Minutes: 10 , Seconds: 15

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString());
            //Output: Hours: 1, Minutes: 0 , Seconds: 0

            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString());
            //Output: Hours: 2, Minutes: 10 , Seconds: 0

            Duration D4 = new Duration(666);
            Console.WriteLine(D4.ToString());
            //Output: Minutes: 11 , Seconds: 6
            Console.WriteLine("D1+D2");

            D3 = D1 + D2;
            Console.WriteLine(D3.ToString());
            D3 = D1 + 7800;

            Console.WriteLine("D1+NUM");
            Console.WriteLine(D3.ToString());

            D3 =  7800 + D1;
            
            Console.WriteLine("NUM+D1");
            Console.WriteLine(D3.ToString());

            D3 = ++D1;
            Console.WriteLine("++D1");
            Console.WriteLine(D3.ToString());

            D4 = D3++;
            Console.WriteLine("++D1");
            Console.WriteLine(D4.ToString());
            Console.WriteLine(D3.ToString());

            Duration D5 = new Duration(0);
            if (D5) { Console.WriteLine("neq zero"); }
            else { Console.WriteLine("eq zero"); }

           DateTime newDate1 = (DateTime)D1;
           Console.WriteLine(newDate1.ToString());

        }

    }

}

//System.DateTime newDate1 = DateTime.Now.Add(duration);  
//System.Console.WriteLine(newDate1); // 1/19/2016 11:47:52 AM  
