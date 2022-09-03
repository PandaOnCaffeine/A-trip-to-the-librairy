namespace A_trip_to_the_librairy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            Stack<Book> bookToLoan = new Stack<Book>();
            Gui gui = new Gui();
            Library library = new Library();

            ConsoleKeyInfo choice;
            library.AddBookToLibrary("A Monster Calls", "Patrick Ness", 2011);
            library.AddBookToLibrary("The Maze Runner", "James Dashner", 2009);
            library.AddBookToLibrary("Harry Potter and the Philosopher's Stone", "J.K. Rowling", 1997);
            library.AddBookToLibrary("")
            do
            {
                Console.Clear();

                gui.Menu();

                choice = Console.ReadKey();

                switch (choice.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        library.ShowBooks();

                        Console.WriteLine("");
                        Console.WriteLine("Press Enter to go back to the menu");
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D2:

                        break;
                    case ConsoleKey.D3:

                        break;
                    default:
                        break;
                }

            } while (exit != true);
        }
    }
}