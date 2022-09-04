namespace A_trip_to_the_librairy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a bool to check if you want to exit the program
            bool exit = false;
            //bool to check if you want to loan more books
            bool loanMore = true;
            //list for the book the user has loaned
            List<Book> usersBag = new List<Book>();
            //stack for the books the user is carrying and want to loan
            Stack<Book> bookToLoan = new Stack<Book>();
            //objekt gui, used to show menu
            Gui gui = new Gui();

            //objekt library
            Library library = new Library();
            
            //a variable to check different choices in the code
            ConsoleKeyInfo choice;

            //Adding 3 books to the Library so it isn't empty
            library.AddBookToLibrary("A Monster Calls", "Patrick Ness", 2011);
            library.AddBookToLibrary("The Maze Runner", "James Dashner", 2009);
            library.AddBookToLibrary("Harry Potter and the Philosopher's Stone", "J.K. Rowling", 1997);

            //a while loop that runs while the user doesn't select exit program
            do
            {
                //Clears console window
                Console.Clear();

                //Show the menu with the gui method called Menu
                gui.Menu();

                //gets users input
                choice = Console.ReadKey();

                //a switch that does different things depending on the key the user pressed
                switch (choice.Key)
                {
                    //user pressed key 1
                    case ConsoleKey.D1:
                        //Clears console
                        Console.Clear();

                        //calls the ShowBooks method to show all books in the library
                        library.ShowBooks();

                        //tells the user how to get back to the menu
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter to go back to the menu");
                        Console.ReadLine();
                        break;
                    //user pressed key 2
                    case ConsoleKey.D2:
                        do
                        {
                            //Clears Console
                            Console.Clear();

                            //shows library books
                            library.ShowBooks();

                            //asks for the users input on what book they want to loan
                            Console.WriteLine("");
                            Console.WriteLine("Type the id of the book you want to loan");
                            int id = int.Parse(Console.ReadLine());

                            //put the book the user want to loan into a stack called bookToLoan and removes the book from the library
                            library.Loan(id, bookToLoan);

                            //Skips a line
                            Console.WriteLine("");

                            //Shows the books the users has selected to loan
                            library.ShowBooksLoaning(bookToLoan);

                            //ask if the user wants to loan more books
                            Console.WriteLine("Do you want to loan more book (y/n)");
                            choice = Console.ReadKey();

                            //Checks users input
                            if (choice.Key == ConsoleKey.N)
                            {
                                //if no sets loanMore to false
                                loanMore = false;
                            }
                            //loop breaks when loanMore isn't true anymore
                        } while (loanMore != false);
                        //Clears Console
                        Console.Clear();
                        
                        //Shows the books the user selected to loan
                        library.ShowBooksLoaning(bookToLoan);

                        //Tells user how to get back to the menu
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter to go back to the menu");
                        Console.ReadLine();
                        break;
                    //user pressed key 3
                    case ConsoleKey.D3:
                        //Clears Console
                        Console.Clear();

                        //Shows the books the user selected to loan
                        library.ShowBooksLoaning(bookToLoan);

                        //ask if user is ready to checkout the books
                        Console.WriteLine("");
                        Console.WriteLine("Ready to check out (y/n)");
                        choice = Console.ReadKey();

                        //Checks users input
                        switch (choice.Key)
                        {
                            //If user pressed key Y
                            case ConsoleKey.Y:
                                //Clears Console
                                Console.Clear();
                                //Checks out all the books the user selected to loan and put them in a list called usersBag
                                library.Checkout(bookToLoan, usersBag);
                                break;
                            default:
                                break;
                        }
                        //Clears Console and tell user how to get back to the menu
                        Console.Clear();
                        Console.WriteLine("Press Enter to go back to the menu");
                        Console.ReadLine();
                        break;
                    //user pressed key 4
                    case ConsoleKey.D4:
                        //Clears Console
                        Console.Clear();
                        //Show the books the user currently has loaned
                        library.ShowCurrentlyLoaned(usersBag);

                        //tells user how to get back to the menu
                        Console.WriteLine("");
                        Console.WriteLine("press Enter to do back to the menu");
                        Console.ReadLine();
                        break;
                    //user pressed key 5
                    case ConsoleKey.D5:
                        //Clears the Console
                        Console.Clear();

                        //asks the user for title of the book they want to donate to the library
                        Console.WriteLine("Write the title of the book you want to donate:");
                        string title = Console.ReadLine();

                        //asks the user for author of the book they want to donate to the library
                        Console.WriteLine("\r\nWrite the name of the Author");
                        string author = Console.ReadLine();

                        //asks the user for year of the book they want to donate to the library
                        Console.WriteLine("\r\nWrite the year the book was made");
                        int year = int.Parse(Console.ReadLine());

                        //adds the book to the library
                        library.AddBookToLibrary(title, author, year);

                        //Thanks the user and tells them how to get back to the menu
                        Console.WriteLine("");
                        Console.WriteLine("Thank you for the donation");
                        Console.WriteLine("press Enter to do back to the menu");
                        Console.ReadLine();
                        break;
                    //user pressed key 6
                    case ConsoleKey.D6:
                        //Clears Console and exits program
                        Console.Clear();
                        exit = true;
                        break;
                    default:
                        break;
                }
                //Breaks the loop when exit isn't false anymore
            } while (exit != true);
        }
    }
}