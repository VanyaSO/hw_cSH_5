// Створіть додаток «Список книг до прочитання». Додаток
// має дозволяти додавати книги до списку, видаляти книги
// зі списку, перевіряти чи є книга у списку, і т.д. Використовуйте механізм властивостей, навантаження операторів,
// індексаторів.

namespace Task_3;

class Program
{
    static void Main(string[] args)
    {
        BooksToRead booksToRead = new BooksToRead(); 
        BooksToRead booksToRead1 = new BooksToRead();
        BooksToRead books = new BooksToRead("Need read", new Book("Война и мир", "Лев Толстой", 1869), new Book("Преступление и наказание", "Федор Достоевский", 1866));

        booksToRead.Show();
        booksToRead1.Show();
        books.Show();
        
        booksToRead.AddBook(new Book("Мастер и Маргарита", "Михаил Булгаков", 1967));
        booksToRead.AddBook(new Book("1984", "Джордж Оруэлл", 1949));
        booksToRead.AddBook(new Book("Про мир", "Неизветный автор", 1999));
        booksToRead.AddBook(new Book("Капитан в море", "Неизветный автор", 1939));
        booksToRead.Show();
        
        books.Show();

        if (books.CheckBook("Мастер и Маргарита"))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Книга \"Мастер и Маргарита\" найдена в {books.Name} ");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Книгу \"Мастер и Маргарита\" не найдена в {books.Name}"); 
            Console.ResetColor();
        }
        
        if (booksToRead.RemoveBook("Мастер и Маргарита"))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Книга \"Мастер и Маргарита\" удалена успешно из {booksToRead.Name} ");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Книгу \"Мастер и Маргарита\" не удалось удалить из {booksToRead.Name}"); 
            Console.ResetColor();
        }
        Console.WriteLine();

        booksToRead.Show();
        
        Console.WriteLine("Сравнение авторов");
        try
        {
            Console.WriteLine(booksToRead.GetBook("Про мир") == booksToRead.GetBook("Капитан в море"));
            Console.WriteLine(booksToRead.GetBook("Про мир") != booksToRead.GetBook("Капитан в море"));
            Console.WriteLine(booksToRead.GetBook("Про мир2") != booksToRead.GetBook("Капитан в море"));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}