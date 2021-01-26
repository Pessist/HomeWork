using System;

namespace Lesson3_3
{
    class Program
    {

        /* Задание:
         * 
         * 3. Написать программу, выводящую введенную пользователем строку в обратном порядке (olleH вместо Hello).
         * 
         */
        

        static void Main(string[] args)
        {
            Console.Write("Введите любую фразу или число: ");
            string greeting = Console.ReadLine();

            Console.WriteLine("\nВывод введенных Вами символов в обратном порядке:\n");

            for (int i = greeting.Length - 1; i >= 0 ; i--)
            {
                Console.WriteLine(greeting[i]); 
            }

        }
    }
}
