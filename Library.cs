
using System;
using System.Collections.Generic;
using System.Linq;

public class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void RemoveBook(string isbn)
    {
        var bookToRemove = books.FirstOrDefault(b => b.ISBN == isbn);
        if (bookToRemove != null)
        {
            books.Remove(bookToRemove);
            Console.WriteLine($"Book with ISBN {isbn} removed.");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }

    public Book SearchBookByTitle(string title)
    {
        return books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
    }

    public void ListAllBooks()
    {
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }
}
