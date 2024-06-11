/* В одному з попередніх практичних завдань ви створювали клас «Магазин». Додайте до вже створеного класу
інформацію про площу магазину. Виконайте навантаження + (для збільшення площі магазину на вказаний
розмір), — (для зменшення площі магазину на вказаний
розмір), == (перевірка на рівність площ магазинів), < і >
(перевірка магазинів менших або більших за площею),
!= і Equals. Використовуйте механізм властивостей
полів класу. */

using Task_2;

namespace Task_1
{
    internal class Program
    {
        static void Main()
        {
            Shop shop1 = new Shop("ATB", 132);
            Shop shop2 = new Shop("Antoshka", 75);

            Console.WriteLine(shop1);
            Console.WriteLine(shop2);
            Console.WriteLine();
            
            Console.WriteLine("==");
            Console.WriteLine(shop1 == shop2);
            Console.WriteLine();
            
            Console.WriteLine("+ and -");
            shop1 = shop1 - 32;
            shop2 = shop2 + 25;
            Console.WriteLine(shop1);
            Console.WriteLine(shop2);
            Console.WriteLine();
            
            Console.WriteLine("!=");
            Console.WriteLine(shop1 != shop2);
            Console.WriteLine();
            
            Console.WriteLine("> and <");
            Console.WriteLine(shop1 > shop2);
            Console.WriteLine(shop1 < shop2);
            Console.WriteLine();

            Console.WriteLine("Equals");
            Console.WriteLine(shop1.Equals(shop2));
        }
    }
}