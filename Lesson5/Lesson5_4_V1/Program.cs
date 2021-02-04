using System;
using System.IO;

namespace Lesson5_4_V1
{
    /*
     * 
     * 4. (*) Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.
     * 
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            string dirName = @"D:\ExampleDir";

            string[] AllFiles = Directory.GetFiles(dirName, "*.*", SearchOption.AllDirectories);

            foreach (string filename in AllFiles)
            {
                Console.WriteLine(filename);
            }

            string filename1 = "track.txt"; //имя файла

            File.WriteAllText(filename1, string.Empty); //очищаем содержимое файла перед внесением информации (для красоты)

            File.AppendAllLines(filename1, AllFiles);

        }
    }
}

