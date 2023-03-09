namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NIC n1 = NIC.singletonObj;
            NIC n2 = NIC.singletonObj;
            Console.WriteLine(n1.GetHashCode());
            Console.WriteLine(n2.GetHashCode());
        }
    }
}