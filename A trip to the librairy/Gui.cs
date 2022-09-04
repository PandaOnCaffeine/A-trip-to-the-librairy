using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_trip_to_the_librairy
{
    internal class Gui
    {
        //method to show the menu
        public void Menu()
        {
            Console.WriteLine("-----++++++++++##########++++++++++-----");
            Console.WriteLine("");
            Console.WriteLine("         Library Loaning Menu");
            Console.WriteLine("");
            Console.WriteLine("-----++++++++++##########++++++++++-----");
            Console.WriteLine("");
            Console.WriteLine("1. Show all book in Library");
            Console.WriteLine("2. Pick books you want to loan");
            Console.WriteLine("3. Checkout the books you want to loan");
            Console.WriteLine("4. Check currently loaned books");
            Console.WriteLine("5. Donate a book to the library");
            Console.WriteLine("6. exit program");
        }
    }
}
