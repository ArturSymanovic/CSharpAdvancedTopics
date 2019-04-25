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
            //Console.WriteLine(Square(5));

            //----------------------------------------------------

            // args => expression       : when there are arguments
            // () => expression         : when no arguments
            // x => expression          : when 1 argument
            // (x, y, z) => expression  : when several arguments


            //----------------------------------------------------

            //Func<int, int> square = number => number * number;
            //Console.WriteLine(square(5));


            //----------------------------------------------------

            //const int factor = 5;

            //Func<int, int> multipler = n => n * factor;

            //var result = multipler(10);

            //Console.WriteLine(result);

            //----------------------------------------------------

            var books = new BookRepository().GetBooks();

            //var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
            var cheapBooks = books.FindAll(book =>book.Price < 10);
            foreach (var item in cheapBooks)
            {
                Console.WriteLine(item.Title);
            }
        }

        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }

        //static int Square(int number)
        //{
        //    return number * number;
        //}
    }
}
