using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_trip_to_the_librairy
{
    internal class Library
    {
        public List<Book> books = new List<Book>();
        private int bookId = 1;
        public void AddBookToLibrary(string title, string author, int year)
        {
            books.Add(new Book(title,author,year,bookId));
            bookId++;
        }

        public void ShowBooks()
        {
            foreach (Book b in books)
            {
                Console.WriteLine($"{b}/ Id: {b.BookId}");
            }
        }
    }
}
