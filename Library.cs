using System.Collections.Generic;

public class Library {
    private string _name;
    private string _location;
    private List<Book> _books = new();

    public Library(string name, string location) {
        _name = name;
        _location = location;
    }

    public string GetName() {
        return _name;
    }

    public string GetLocation() {
        return _location;
    }

    public void AddBook(Book book) {
        _books.Add(book);
    }

    public List<Book> GetBooks() {
        return _books;
    }
}