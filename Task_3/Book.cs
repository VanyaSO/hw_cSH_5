namespace Task_3;

public class Book
{
    public string Name { get; set; }
    public string Author { get; set; }
    public uint Year { get; set; }
    
    public Book(){}

    public Book(string name, string author, uint year)
    {
        Name = name;
        Author = author;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Name} - {Author} - {Year}";
    }

    public static bool operator ==(Book bookL, Book bookR)
    {
        return String.Compare(bookL.Author, bookR.Author) == 0;
    }
    
    public static bool operator !=(Book bookL, Book bookR)
    {
        return String.Compare(bookL.Author, bookR.Author) != 0;
    }
}