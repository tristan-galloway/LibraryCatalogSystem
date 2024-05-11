using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCatalogSystem;


class Program
{
    static void Main(string[] args)
    {

        Library library = new("Yorknew City Library", "1st St Yale");
        Book book1 = new("Unbroken", "Laura Hillenbrand");
        Book book2 = new("The Lord of The Rings", "J. R. R. Tolkien");
        Book book3 = new("The Hunder Games", "Suzanne Collins");
        Book book4 = new("Percy Jackson & the Olympians", "Rick Riordan");

        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);
        library.AddBook(book4);

        MenuManager menu = new(library);

        menu.Run();
        menu.GetMenu();
    }
}
