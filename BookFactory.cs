
public class BookFactory
{
    public static Book CreateBook(string type, string title, string author, string isbn, bool available, int fileSize = 0)
    {
        return type.ToLower() switch
        {
            "ebook" => new EBook(title, author, isbn, available, fileSize),
            "book" => new Book(title, author, isbn, available),
            _ => throw new ArgumentException("Invalid book type.")
        };
    }
}
