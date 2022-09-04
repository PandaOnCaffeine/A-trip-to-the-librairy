using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_trip_to_the_librairy
{
    internal class Book
    {
        //Properties
        private string title;
        private string author;
        private int year;


        //Contructer
        public Book(string title, string author, int year)
        {
            this.title = title;
            this.author = author;
            this.year = year;
        }
        //ToString Override, so it show the right thing when you try to show a book
        public override string ToString()
        {
            return title + " By " + author + ", from " + year;
        }
    }
}
