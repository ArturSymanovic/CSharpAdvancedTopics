using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example1();


            var books = new BookRepository().GetBooks();
            //Return MVC book

            //breaks if does not exist
            var book = books.Single(b => b.Title == "ASP.NET MVC");
            Console.WriteLine(book.Title);
            
            //retuns default value if does not exist 
            book = books.SingleOrDefault(b => b.Title == "ASP.NET MVC++");
            Console.WriteLine(book==null);

            //breaks if does not exist
            book = books.First(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(book.Title + " " + book.Price);

            //retuns default value if does not exist 
            book = books.FirstOrDefault(b => b.Title == "C# Advanced Topics111");
            Console.WriteLine(book == null);

            //breaks if does not exist
            book = books.Last(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(book.Title + " " + book.Price);

            //retuns default value if does not exist 
            book = books.LastOrDefault(b => b.Title == "C# Advanced Topics111");
            Console.WriteLine(book == null);

            
            var subBooks = books.Skip(5).Take(3);
            foreach (var abook in subBooks)
            {
                Console.WriteLine(abook.Title);
            }

            var count = books.Count();
            Console.WriteLine(count);

            var max = books.Max(b => b.Price);
            Console.WriteLine(max);

            var min = books.Min(b => b.Price);
            Console.WriteLine(min);

            var total = books.Sum(b => b.Price);
            Console.WriteLine(total);
        }

        private static void Example1()
        {
            var books = new BookRepository().GetBooks();

            //Without LINQ
            //var cheapBooks = new List<Book>();
            //foreach (var book in books)
            //{
            //    if (book.Price < 10)
            //        cheapBooks.Add(book);
            //}

            //LINQ Query Operators
            var cheaperBooks = from b in books
                               where b.Price < 10f
                               orderby b.Title
                               select b.Title;



            //LINQ Extension Methods
            var cheapBooks = books
                                .Where(b => b.Price < 10f)
                                .OrderBy(b => b.Title)
                                .Select(b => b.Title);
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book);
                //Console.WriteLine(book.Title + " " + book.Price);
            }
        }
    }
}
