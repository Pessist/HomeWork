using System;
using System.IO;
using System.Text.Json;

namespace Lesson5_2
{
    /*
     * 
     * 2. Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
     * 
     * 
     */

    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.Now;
            string timeNow = time.ToString("HH.mm.ss");
            string filename1 = "MyFirstText.txt";

            File.WriteAllText(filename1, timeNow);//Записываем файл текущее время
            File.AppendAllText(filename1, Environment.NewLine); // вставляем перенос строки

            string[] text = new string[1];
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine("Введите произвольный нобор данных: ");
                text[i] = Console.ReadLine();
                Console.WriteLine("\nВот то что Вы набрали:");
                Console.WriteLine(text[i]);
                File.AppendAllLines(filename1, text);
            }

            string filename2 = "startup.txt";
            File.WriteAllText(filename2, timeNow);

            Console.WriteLine("\nА сам текстовый файл ноходится в проэкте .../ bin / Debug / netcoreapp3.1 /");
        }
    }
}
