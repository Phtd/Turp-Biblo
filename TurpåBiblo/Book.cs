using System;
using System.Collections.Generic;
using System.Text;

namespace TurpåBiblo
{
    class Book
    {
        public string Name { get; set; } // 
        public string Author { get; set; } // 
        public int WrittenYear { get; set; } // 

        public override string ToString() // Function that gets called by bookList.ForEach(Console.WriteLine); in Program, and helps it display the list
        {
            return " Name :  " + Name + "\n Author :  " + Author + "\n Written in the Year :  " + WrittenYear + "\n"; // Returns the values to be printed and some text to tell which is which
        }
        public Book() // The constructor for Book
        {

        }


    }
}
