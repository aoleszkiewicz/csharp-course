namespace Static_Modifier;

public class Book
{
    private string _title;
    private string _author;
    private int _pages;
    private static int _bookCount;
    
    public Book(string title, string author, int pages)
    {
        _title = title;
        _author = author;
        _pages = pages;
        // Increment _bookCount everytime book object is created.
        _bookCount++;
    }

    public static int GetBookCount()
    {
        return _bookCount;
    }
}