using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8
{
    
    public class Book
        {
            public string ISBN { get; set; }
            public string Title { get; set; }
            public string[] Authors { get; set; }
            public DateTime PublicationDate { get; set; }
            public decimal Price { get; set; }
            public Book(string _ISBN, string _Title,
            string[] _Authors, DateTime _PublicationDate,
            decimal _Price)
            {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
            }
            public override string ToString()
            {
            return $" Isbn: {ISBN}, title: {Title}, authors: {Authors}, PublicationDate: {PublicationDate}, price:{Price}";
            }
        }
        public class BookFunctions
        {
            public static string GetTitle(Book B)
            {
            return B.Title;
            }
            public static string GetAuthors(Book B)
            {
            string s = "";
            for(int i = 0; i < B.Authors.Length; i++)
            {
                s+= B.Authors[i].ToString()+"\n";
            }
            return s;
            }
            public static string GetPrice(Book B)
            {
                return B.Price.ToString();
            }
            
    }
    public class LibraryEngine
    {

        public static void ProcessBooks(List<Book> bList,/*Pointer To BookFunciton*/ DelDT fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
        public static void ProcessBooks(List<Book> bList,/*Pointer To BookFunciton*/ Func<Book,string> fun)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fun(B));
            }
        }
    }
}

