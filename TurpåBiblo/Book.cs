using System;
using System.Collections.Generic;
using System.Text;

namespace TurpåBiblo
{
    class Book
    {
        private string name;
        private string author;
        private int writtenYear;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public int WrittenYear
        {
            get { return writtenYear; }
            set { writtenYear = value; }
        }
        public override string ToString()                                       // Function that gets called by bookList.ForEach(Console.WriteLine); in Program, and helps it display the list
        {
            return " Name :  " + Name + "\n Author :  " + Author + "\n Written in the Year :  " + WrittenYear + "\n"; // Returns the values to be printed and some text to tell which is which
        }
        public Book()                                                           // The constructor for Book
        {

        }


    }
}
