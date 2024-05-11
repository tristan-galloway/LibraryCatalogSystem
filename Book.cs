public class Book {
    private string _title;
    private string _author;
    private bool _isAvalailable;
    
    public Book(string title, string author) {
        _title = title;
        _author = author;
        _isAvalailable = true;
    }

    public string GetTitle() {
        return _title;
    }

    public string GetAuthor() {
        return _author;
    }

    public bool IsAvalailable() {
        return _isAvalailable;
    }

    public string GetBookInfo() {
        return $"{GetTitle()},{GetAuthor()},{IsAvalailable()}";
    }

    public void BorrowBook() {
        _isAvalailable = false;
    }

    public void ReturnBook() {
        _isAvalailable = true;
    }
}