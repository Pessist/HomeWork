using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Здравствуйте. Введите Ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, сегодня {DateTime.Now}");
        }
    }
}
