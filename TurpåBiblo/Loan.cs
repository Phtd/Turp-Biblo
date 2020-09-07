using System;
using System.Collections.Generic;
using System.Text;

namespace TurpåBiblo
{
    class Loan
    {
        public static List<Book> Loaner(List<Book> AvailableBooks)
        {
            bool Done = false;
            Stack<Book> loanerBooks = new Stack<Book>(); // The loaners stack, that gets filled with the books that get loaned
            while (!Done)
            {
                Console.WriteLine("\n Number of available books "+ AvailableBooks.Count +"\n");
                Console.WriteLine("Hello.\n Please choose from the following,\n Press 1 to loan books\n Press 2 to turn in books,\n Press 3 to check out"); // Console Writeline that presents the options
                int choice = Convert.ToInt32(Console.ReadLine()); // Reads our choice, and gives choice a value to be used in the switch case
                switch (choice) // a switch case containing multiple options
                {
                    case 1: // First case in the switch case, contains the loaning function
                        Console.WriteLine("Here is a list of books available to loan\n"); // a Writeline that tells we can loan books here
                        AvailableBooks.ForEach(Console.WriteLine); // Displays the available books to the user
                        string loanChoice = Console.ReadLine(); // 
                        Book bookToBeLoaned = new Book(); // Makes bookToBeLoaned into a object to be used later
                        foreach (Book book in AvailableBooks) // A foreach loop that looks throught the list of AvailableBooks 
                        {
                            if (book.Name.Contains(loanChoice)) // an if statement that looks and checks to make sure the list contains the wished item
                            {
                                bookToBeLoaned = book;
                            }
                        }
                        if (bookToBeLoaned.Author != null) // 
                        {
                            loanerBooks.Push(bookToBeLoaned);  // Moves the wished item into the stack of the loaner
                            AvailableBooks.Remove(bookToBeLoaned); // Removes the loaned item from the list since its been moved to the stack
                        }

                        break; // A break, that will return the user back out of the switch case
                    case 2:
                        Console.WriteLine("Thanks you for turning in all books"); // Console writeline that tells us we can return our loaned books back here
                        while (loanerBooks.Count != 0) // Will run as long as there is anything in the stack from the loaner
                        {
                            AvailableBooks.Add(loanerBooks.Pop()); // Returns all the books from the stack back to the list
                        }
                        break; // A break, that will return the user back out of the switch case
                    case 3:
                        Console.WriteLine("Have a nice day");
                        Done = true;
                        break; // A break, that will return the user back out of the switch case

                }

            }
            return AvailableBooks;
        }
    }
}
