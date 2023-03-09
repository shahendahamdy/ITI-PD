namespace day8
{
    //user defined
    public delegate string DelDT(Book b);

    public class Program
    {
        
        static void Main(string[] args)
        {
            string [] arr = { "a", "b", "c", "d" };
            Book b1 = new Book("aa", "Book1", arr, DateTime.Now, 505555);
            Book b2 = new Book("bb", "Book2", arr, DateTime.Now, 11111);
            Book b3 = new Book("cc", "Book3", arr, DateTime.Now, 12235);
            List<Book> list = new List<Book>();     
            list.Add(b1);list.Add(b2);list.Add(b3);
            //Method #1
            DelDT fPtr = new DelDT(BookFunctions.GetTitle);
            LibraryEngine.ProcessBooks(list, fPtr);
            Console.WriteLine("\n\n");

            //Method #2
            Func<Book, string> fun = BookFunctions.GetPrice;
            LibraryEngine.ProcessBooks(list, fun);
            Console.WriteLine("\n\n");

            //Method #3 Anonymous Method
            Func<Book, string> anony = delegate (Book b) { return  b.ISBN; };
            LibraryEngine.ProcessBooks(list, anony);
            Console.WriteLine("\n\n");

            //Method #4 Lambda Expression (GetPublicationDate)
            Func<Book, string> lam =  b =>  b.PublicationDate.ToString();
            LibraryEngine.ProcessBooks(list, lam);
            Console.WriteLine("\n\n");



        }
    }
}