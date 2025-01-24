
using System;

public class LibraryManager
{
    private Library library = new Library();

    public void Menu()
    {
        while (true)
        {
            Console.WriteLine("\nLibrary Management Menu:");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. Search Book");
            Console.WriteLine("4. List All Books");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter author: ");
                    string author = Console.ReadLine();
                    Console.Write("Enter ISBN: ");
                    string isbn = Console.ReadLine();
                    Console.Write("Is it available? (true/false): ");
                    bool available = bool.Parse(Console.ReadLine());
                    library.AddBook(new Book(title, author, isbn, available));
                    break;
                case 2:
                    Console.Write("Enter ISBN to remove: ");
                    string removeISBN = Console.ReadLine();
                    library.RemoveBook(removeISBN);
                    break;
                case 3:
                    Console.Write("Enter title to search: ");
                    string searchTitle = Console.ReadLine();
                    var searchedBook = library.SearchBookByTitle(searchTitle);
                    Console.WriteLine(searchedBook != null ? searchedBook.ToString() : "Book not found.");
                    break;
                case 4:
                    library.ListAllBooks();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
