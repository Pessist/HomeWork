using System;
using System.IO;
using System.Text.Json;

namespace Lesson5_1
{
    /*
     * 
     * 1. Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
     * 
     * 
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольный нобор данных: ");
            string text = Console.ReadLine();
            string filename = "MyFirstText.txt";
            File.WriteAllText(filename, text); //Записываем файл в строку
            Console.WriteLine("\nВот то что Вы набрали:");
            Console.WriteLine(text);
            Console.WriteLine("\nА сам текстовый файл ноходится в проэкте .../ bin / Debug / netcoreapp3.1 /");
        }
    }
}
