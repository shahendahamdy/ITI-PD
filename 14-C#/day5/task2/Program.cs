namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            math m = new math();
            System.Console.WriteLine(m.add(8, 4));
            System.Console.WriteLine(m.Subtract(8, 4));
            System.Console.WriteLine(m.Multiply(8, 4));
            System.Console.WriteLine(m.Divide(8, 4));
            
            System.Console.WriteLine(math2.add(8, 4));
            System.Console.WriteLine(math2.Subtract(8, 4));
            System.Console.WriteLine(math2.Multiply(8, 4));
            System.Console.WriteLine(math2.Divide(8, 4));
        }
    }
}