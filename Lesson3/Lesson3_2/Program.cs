using System;

namespace Lesson3_2
{
    class Program
    {
        /* Задание:
         * 
         * 
         * 
         * 2. Написать программу — телефонный справочник — создать двумерный массив 5*2, 
         * хранящий список телефонных контактов: первый элемент хранит имя контакта, 
         * второй — номер телефона/e-mail.
         * 
         * 
         */


        static void Main(string[] args)
        {
            string[,] phoneBook = new string [5, 2];
           

            for (int i = 0; i < phoneBook.GetLength(0); i++)
            {
                Console.Write("Введите фамилию: ");
                string name = Console.ReadLine();
                phoneBook[i,0] = name;
            }
            
            for (int j = 0; j < phoneBook.GetLength(0); j++)
            {
                Console.Write("\nВведите телефон: ");
                string phone = Console.ReadLine();
                phoneBook[j,1] = phone;

            }

            Console.WriteLine("\nТелефонный справочник готов:");

            for (int i = 0; i < phoneBook.GetLength(0); i++)
            {
                Console.Write("ФИО/Телефон: \t");

                for (int j = 0; j < phoneBook.GetLength(1); j++)
                {
                    
                    Console.Write(phoneBook[i, j] + "\t");
                
                }
                
                Console.WriteLine();
            }



        }
    }
}
