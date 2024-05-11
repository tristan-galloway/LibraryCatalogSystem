public class MenuManager {
    private Library _library;

    public MenuManager(Library library) {
        _library = library;
    }

    public void Run() {
        Console.WriteLine($"Welcome to the {_library.GetName()}!");
    }

    public void GetMenu() {
        Console.WriteLine("Choose what you would like to do today.");

        int answer = 0;

        while (answer != 5)
        {
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
                    BookInventory();
                    break;
                case 2:
                    CheckAvailability();
                    break;
                case 3:
                    BorrowBook();
                    break;
                case 4:
                    ReturnBook();
                    break;
                case 5:
                    break;
            }
        }
        
    }

    public void BookInventory() {
        Console.WriteLine("Enter a ");
    }

    public void CheckAvailability() {
        Console.WriteLine("");
    }

    public void BorrowBook() {
        Console.Write("What book would you like to borrow? ");
        string answer = Console.ReadLine();

        // if (book.IsAvalailable() == true) // Actualy logic needs figured out
        // {

        // }
    }

    public void ReturnBook() {
        Console.Write("What book would you like to return? ");
        string response = Console.ReadLine();


    }
}