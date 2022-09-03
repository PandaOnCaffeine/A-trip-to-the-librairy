using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_trip_to_the_librairy
{
    internal class Book
    {
        private string title;
        private string author;
        private int year;
        private int bookId;
        public string Title { get { return title; } }
        public string Author { get { return author; } }
        public int Year { get { return year; } }
        public int BookId { get { return bookId; } }

        public Book(string title, string author, int year, int bookId)
        {
            this.title = title;
            this.author = author;
            this.year = year;
            this.bookId = bookId;
        }

        public void Loan(int bookId)
        {

        }

        public override string ToString()
        {
            return title + " By " + author + ", With " + pages + " Pages";
        }
    }
}
