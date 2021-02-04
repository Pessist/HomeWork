using System;
using System.IO;

namespace Lesson5_4_V2
{
    class Program
    {
        /*
         * 
        * 4. (*) Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.
        * 
        * 
        */
        static bool TreeDirectory(string Dir, bool Sub)
        {
            string fileName = "TreeCatalog.txt";
            string tab = " ";
            string[] files = Directory.GetFiles(Dir);

            File.WriteAllText(fileName, string.Empty);

            File.AppendAllLines(fileName, files);
            tab += "-";

            foreach (string file in files)
            {
                string[] fileInDir = { string.Concat(tab, " ", Path.GetFileName(file)) };
                File.AppendAllLines(fileName, fileInDir);
            }

            foreach (string folder in Directory.GetDirectories(Dir))
            {
                TreeDirectory(folder, Sub);
            }

            return true;
        }
        static void Main(string[] args)
        {
            TreeDirectory(@"D:\ExampleDir", true);
        }
    }
}
