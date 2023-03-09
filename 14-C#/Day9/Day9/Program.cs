namespace Day9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            SalesPerson e1= new SalesPerson(1,new DateTime(1950, 3, 1, 7, 0, 0) , 100);
            Employee e2= new Employee(2, new DateTime(1970, 3, 1, 7, 0, 0));
            BoardMember e3= new BoardMember(3, new DateTime(2000, 3, 1, 7, 0, 0));
            Department d1= new Department(1,"d1");

            Console.WriteLine(e1.CheckTarget(10));
            //            Console.WriteLine(e1.CheckTarget(10));
            e2.EndOfYearOperation();
            e3.Resign();
            

        }
    }
}