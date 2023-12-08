namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();
            while (true)
            {
                MenuOption.GetMenuOption();

                switch (MenuOption.Option)
                {
                    case (Options)1:
                        string[] details = GetBookDetails();
                        if (details.Length == 3)
                        {
                            library.AddBook(new Book(details[0], details[1], details[2]));
                            Console.WriteLine("Book added successfully");
                            break;
                        }
                        Console.WriteLine("Invalid details");
                        break;

                    case (Options)2:
                        var isbn = GetISBN();
                        if (library.Exists(isbn))
                        {
                            library.RemoveBook(isbn);
                            Console.WriteLine("Book removed successfully");
                            break;
                        }
                        Console.WriteLine("Book not found");
                        break;

                    case (Options)3:
                        library.PrintAllBooks();
                        break;

                    case (Options)4:
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        private static string? GetISBN()
        {
            Console.WriteLine("Enter ISBN of the book to remove");
            var isbn = Console.ReadLine();
            return isbn;
        }

        private static string[] GetBookDetails()
        {
            Console.WriteLine("Enter book details - Title, Author, ISBN");
            var details = Console.ReadLine().Split(',');
            return details;
        }
    }

    public enum Options
    {
        AddBook = 1, RemoveBook = 2, ListAllBooks = 3, Exit = 4
    }
    public static class MenuOption
    {
        public static Options Option;
        public static void GetMenuOption()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1: Add a book");
            Console.WriteLine("2: Remove a book");
            Console.WriteLine("3: List all books");
            Console.WriteLine("4: Exit");

            var input = Console.ReadLine();

            Option = (Options)Enum.Parse(typeof(Options), input);
        }
    }

    public class Library
    {
        private List<Book> books = new List<Book>();
        public bool Exists(string isbn)
        {
            return books.Exists(a => a.ISBN == isbn);
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(string isbn)
        {
            var bookToRemove = books.Find(b => b.ISBN == isbn);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
            }
        }

        public List<Book> ListBooks()
        {
            return books;
        }
        public void PrintAllBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }

    public class Book
    {
        public string Title;
        public string Author { get; set; }
        public string ISBN { get; set; }

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }
        public override string ToString()
        {
            return $"Title: {this.Title}, Author: {this.Author}, ISBN: {this.ISBN}";
        }
    }
}