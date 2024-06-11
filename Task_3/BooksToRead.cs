namespace Task_3;

public class BooksToRead
{
    public string Name { get; set; }
    private List<Book> _books;
    private static int _count;

    static BooksToRead()
    {
        _count = 0;
    }

    public BooksToRead(string? name): this(name, new Book[]{}){}
    public BooksToRead(string? name, params Book[] books)
    {
        Name = name ?? (_count > 0 ? $"no name({_count})" : "no name");
        _books = new List<Book>(books);
        _count += 1;
    }

    public void AddBook(Book newBook)
    {
        _books.Add(newBook);
    }
    
    public bool RemoveBook(string name)
    {
        return _books.Remove(_books.Find(book => book.Name.Contains(name)));
    }

    public bool CheckBook(string name)
    {
        Book book = _books.Find(book => book.Name.Contains(name));
        if (book is null)
            return false;
        
        return true;
    }

    public Book GetBook(string name)
    {
        return _books.Find(book => book.Name.Contains(name));
    }

    public override string ToString()
    {
        Console.WriteLine($"Name: {Name}, Count books: {_books.Count}");
        foreach (var book in _books)
        {
            Console.WriteLine(book);
        }
        return "";
    }
}