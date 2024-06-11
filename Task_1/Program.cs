/* В одному з попередніх практичних завдань ви створювали клас «Журнал». Додайте до вже створеного класу
інформацію про кількість працівників. Виконайте навантаження + (для збільшення кількості працівників на вказану кількість), — (для зменшення кількості працівників
на вказану кількість), == (перевірка на рівність кількості
працівників), < і > (перевірка на меншу чи більшу кількість працівників), != і Equals. Використовуйте механізм
властивостей полів класу. */

namespace Task_1
{
    internal class Program
    {
        static void Main()
        {
            Magazine mag1 = new Magazine("About money", 56);
            Magazine mag2 = new Magazine("News", 56);

            Console.WriteLine(mag1);
            Console.WriteLine(mag2);
            Console.WriteLine();
            
            Console.WriteLine("==");
            Console.WriteLine(mag1 == mag2);
            Console.WriteLine();
            
            Console.WriteLine("+ and -");
            mag1 = mag1 + 10;
            mag2 = mag2 - 2;
            Console.WriteLine(mag1);
            Console.WriteLine(mag2);
            Console.WriteLine();
            
            Console.WriteLine("!=");
            Console.WriteLine(mag1 != mag2);
            Console.WriteLine();
            
            Console.WriteLine("> and <");
            Console.WriteLine(mag1 > mag2);
            Console.WriteLine(mag1 < mag2);
            Console.WriteLine();

            Console.WriteLine("Equals");
            Console.WriteLine(mag1.Equals(mag2));
        }
    }
}