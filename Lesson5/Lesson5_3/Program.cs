using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lesson5_3
{
    /*
     * 
     * 3. Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
     * 
     * 
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Необходимо ввести произвольный набор чисел (0...255)");
            Console.Write("Введите количество вводимых чисел: ");
            int n = int.Parse(Console.ReadLine());

            int[] arrayNambers = new int[n];

            //Заполняем массив произвольными значениями
            for (int i = 0; i < arrayNambers.Length; i++)
            {
                Console.Write($"\nВведите {i + 1} число: ");
                int nambers = int.Parse(Console.ReadLine());
                arrayNambers[i] = nambers;
            }

            Console.WriteLine("\nВведенный Вами массив произовльных чисел:");
            for (int i = 0; i < arrayNambers.Length; i++)
            {
                Console.Write(arrayNambers[i]);
                Console.Write(" ");
            }

            // Создаём объект BinaryWriter
            BinaryWriter bWriter = new BinaryWriter(new FileStream("numbers.bin", FileMode.OpenOrCreate));
            for (int i = 0; i < arrayNambers.Length; i++)
            {
                bWriter.Write(arrayNambers[i]);
                Console.Write(" ");
                if (i == arrayNambers.Length - 1)
                {
                    bWriter.Close(); //Не забываем закрывать поток, tсли не закроем, то при чтении могут возникнуть ошибки с доступом
                }
            }
        }
    }
}
