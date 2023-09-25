using Static_Modifier;

public static class Program
{
    public static void Main()
    {
        Book book1 = new Book("Harry Potter", "JK Rowling", 400);
        Book book2 = new Book("Harry Potter", "JK Rowling", 400);
        Book book3 = new Book("Harry Potter", "JK Rowling", 400);
        
        System.Console.WriteLine(Book.GetBookCount());
    }
}