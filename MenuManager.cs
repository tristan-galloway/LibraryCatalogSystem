using System.Runtime.ExceptionServices;
using System.Xml.Serialization;

public class MenuManager {
    private Library _library;

    public MenuManager(Library library) {
        _library = library;
    }

    public void Run() {
        Console.WriteLine($"Welcome to the {_library.GetName()}!");
    }

    public void GetMenu() {
        // This method calls the menu and displays it to the user. 
        // The user then can select the option they want and the method then calls the needed code.

        int answer = 0;

        while (answer != 5)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Choose what you would like to do today.");
            Console.WriteLine("     [1] See Book Inventory.");
            Console.WriteLine("     [2] Check availability.");
            Console.WriteLine("     [3] Borrow a book.");
            Console.WriteLine("     [4] Return a book"); 
            Console.WriteLine("     [5] Exit the App.");
            Console.Write("Enter your selection: ");

            string response = Console.ReadLine();
            answer = int.Parse(response);

            switch (answer)
            {
                case 1:
                    Console.WriteLine(" ");
                    BookInventory();
                    break;
                case 2:
                    Console.WriteLine(" ");
                    CheckAvailability();
                    break;
                case 3:
                    Console.WriteLine(" ");
                    BorrowBook();
                    break;
                case 4:
                    Console.WriteLine(" ");
                    ReturnBook();
                    break;
                case 5:
                    Console.WriteLine(" ");
                    ThankYouMessage();
                    break;
            }
        }
    }
      public void BookInventory() {
        // Displays all the books in the library in a numbered list.
        Console.WriteLine("Here is our current catalog of books.");

        // Iterates throught the library printing each title and author of each book.
        for (int i = 0; i < _library.GetBooks().Count; i++) 
        {
            Console.WriteLine($"   [{i + 1}] {_library.GetBooks()[i].GetTitle()} by {_library.GetBooks()[i].GetAuthor()}");
        }
    }

    public void CheckAvailability() {
        // User enters a book name, the system returns whether or not the book is available.
        Console.Write("What book would you like to check it's availability? ");
        string response = Console.ReadLine();

        // && b.IsAvalailable() == true
        // b.GetTitle().Contains(response, StringComparison.OrdinalIgnoreCase))

        foreach (Book b in _library.GetBooks()) {
            if (b.GetTitle().Contains(response, StringComparison.OrdinalIgnoreCase)) {
                if (b.IsAvalailable() == true) {
                    Console.WriteLine($"The book '{b.GetTitle()}' is available.");
                } else {
                    Console.WriteLine($"The book '{b.GetTitle()}' not available");
                }
                
            }
        }
    }

    public void BorrowBook() {
        // Show the user the books in the library.
        BookInventory();

        // Ask which book they'd like to borrow.
        Console.Write("Select the book you'd like to borrow: ");
        string answer = Console.ReadLine();
        // Convert the users choice to an int index value
        int choice = int.Parse(answer) - 1;

        // If the book is available, mark it as borrowed. Otherwise, let the user know.
        if (_library.GetBooks()[choice].IsAvalailable() == true) {
            Console.WriteLine($"\nThe book '{_library.GetBooks()[choice].GetTitle()}' is available, we'll send it to your listed address.");
            _library.GetBooks()[choice].BorrowBook();
        } else {
            Console.WriteLine($"\nSorry, {_library.GetBooks()[choice].GetTitle()} is not currently available.");
        }
        
    }

    public void ReturnBook() {
        Console.Write("What book would you like to return? ");
        string response = Console.ReadLine();

        // Search for the book in the book list, if we have it, mark it as available again.
        foreach (Book b in _library.GetBooks()) {
            if (b.GetTitle().Contains(response, StringComparison.OrdinalIgnoreCase)) {
                Console.WriteLine($"Thank you for returning {b.GetTitle()}");
                b.ReturnBook();
            }
        }

    }

    public void ThankYouMessage() {
        Console.WriteLine("Thank you for choosing Yorknew City Library. Enjoy your day!");
    }
}