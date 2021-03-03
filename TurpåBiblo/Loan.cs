using System;
using System.Collections.Generic;
using System.Text;

namespace TurpåBiblo
{
    class Loan
    {
        public static List<Book> Loaner(List<Book> AvailableBooks)
        {
            bool DoneLoan = false;
            bool Done = false;
            Stack<Book> loanerBooks = new Stack<Book>();                                                             // The loaners stack, that gets filled with the books that get loaned
            while (!Done)
            {
                Console.Clear();
                Console.WriteLine("\n Number of available books " + AvailableBooks.Count + "\n");
                Console.WriteLine("========Hello========\nPlease choose from the following,\nPress 1 to loan books\nPress 2 to turn in books\nPress 3 to see the latest book you have loaned \nPress 4 to check out"); // Console Writeline that presents the options
                int choice = Convert.ToInt32(Console.ReadLine());                                                    // Reads our choice, and gives choice a value to be used in the switch case
                switch (choice)                                                                                      // a switch case containing multiple options
                {                                                                                                    
                    case 1:                                                                                          // First case in the switch case, contains the loaning function
                        DoneLoan = false;                                                                            // Sets DoneLoan to false so we can reenter the case, else it remains true after we exit it
                        while (!DoneLoan)                                                                            
                        {                                                                                            
                            Console.Clear();                                                                         
                            Console.WriteLine("Here is a list of books available to loan\n");                        // a Writeline that tells we can loan books here
                            AvailableBooks.ForEach(Console.WriteLine);                                               // Displays the available books to the user
                            string loanChoice = Console.ReadLine();                                                  // 
                            Book bookToBeLoaned = new Book();                                                        // Makes bookToBeLoaned into a object to be used later
                            foreach (Book book in AvailableBooks)                                                    // A foreach loop that looks throught the list of AvailableBooks 
                            {
                                if (book.Name.ToLower().Contains(loanChoice.ToLower()))                              // an if statement that looks and checks to make sure the list contains the wished item
                                {
                                    bookToBeLoaned = book;
                                    loanerBooks.Push(bookToBeLoaned);                                                // Moves the wished item into the stack of the loaner
                                    AvailableBooks.Remove(bookToBeLoaned);                                           // Removes the loaned item from the list since its been moved to the stack
                                    break;
                                }
                            }
                            Console.WriteLine("Do you want to loan more y/n?");
                            string moreChoice = Console.ReadLine();                                                  // Makes a container for the new choice and puts the value into it when its typed
                            if (moreChoice == "y")                                                                   // Loops back so one can loan more books if true
                            {

                            }
                            else if (moreChoice == "n")                                                             
                            {                                                                                        // Sets DoneLoan to true so we come out of the loop
                                DoneLoan = true;

                            }
                        }
                        break;                                                                                       // A break, that will return the user back out of the switch case
                    case 2:
                        Console.WriteLine("Thanks you for turning in all books");                                    // Console writeline that tells us we can return our loaned books back here
                        while (loanerBooks.Count != 0)                                                               // Will run as long as there is anything in the stack from the loaner
                        {
                            AvailableBooks.Add(loanerBooks.Pop());                                                   // Returns all the books from the stack back to the list
                        }
                        break;                                                                                       // A break, that will return the user back out of the switch case
                    case 3:
                        if (loanerBooks.Count != 0)                                                                  // If we have any books in our stack, this runs
                        {
                            Console.WriteLine("The latest book you have borrowed is = " + loanerBooks.Peek().Name);  // Tells us the latest book to be loaned
                            Console.ReadKey();                                                                       // Gives us time to read the message
                            Console.Clear();                                                                         // clears the text so we get a clean window
                        }
                        else if (loanerBooks.Count == 0)                                                             // if we havnt loaned any books yet, this runs
                        {
                            Console.WriteLine("You havnt borrowed any books yet");                                   // Simple Message
                            Console.ReadKey();                                                                       // Time Maker
                            Console.Clear();                                                                         // Clears the window of text
                        }
                        break;
                    case 4:
                        Console.WriteLine("Have a nice day");
                        Done = true;
                        break;                                                                                      // A break, that will return the user back out of the switch case

                }

            }
            return AvailableBooks;
        }
    }
}
