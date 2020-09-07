using System;
using System.Collections.Generic;

namespace TurpåBiblo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Book> bookList = new List<Book>(); // The list that contains the books

            bookList.Add(new Book() { Name = "Fred's guide to carpentry", Author = "Fred Goldtooth", WrittenYear = 2009 }); // Makes a new Book, with the aforementioned values to Name, Author and WrittenYear
            bookList.Add(new Book() { Name = "Death's Embrace", Author = "Heinrich Kremler", WrittenYear = 1986 }); // Makes a new Book, with the aforementioned values to Name, Author and WrittenYear
            bookList.Add(new Book() { Name = "Harry Potter", Author = "J.K. Rowling", WrittenYear = 2001 }); // Makes a new Book, with the aforementioned values to Name, Author and WrittenYear
            bookList.Add(new Book() { Name = "Art of Falling", Author = "Henriette Krüger", WrittenYear = 2014 }); // Makes a new Book, with the aforementioned values to Name, Author and WrittenYear
            Loan.Loaner(bookList);

            bookList.ForEach(Console.WriteLine); // A foreach loop and reads through the list, calls the override ToString and displays the list
           
            Console.ReadKey();
        }
    }
}
