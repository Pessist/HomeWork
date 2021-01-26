using System;

namespace Lesson3_1
{
    class Program
    {
        /* Задание:
         * 
         * 
         * 
         * 1. Написать программу, выводящую элементы двухмерного массива по диагонали.
         * 
         * 
         */

        static void Main(string[] args)
        {
            int[,] myArray = new int[5, 5];

            Random random = new Random();

            Console.WriteLine("Вывод данных двумерного массива:");

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = random.Next(100);
                    Console.Write(myArray[i, j] + "\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nВывод данных главной диагонали:");

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {
                    if (i == j)
                    {
                        Console.Write($"{myArray[i, j]} ");
                    }
                    else
                    {
                        continue;
                    }

                }

                Console.WriteLine();
            }

            Console.Write("\nВывод данных ниже главной диагонали:");

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    if (i == j + 1)
                    {
                        Console.Write($"{myArray[i, j]}");
                    }
                    else
                    {
                        continue;
                    }

                }

                Console.WriteLine();
            }

            Console.WriteLine("\nВывод данных выше главной диагонали:");

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    if (j == i + 1)
                    {
                        Console.Write($"{myArray[i, j]}");
                    }
                    else
                    {
                        continue;
                    }

                }

                Console.WriteLine();
            }

            /* оказалось что все можно было записать одной строчкой вот так... 
            for (int i = 0; i < myArray.GetLength(0); ++i)
            {
                Console.Write($"{myArray[i, i]} ");
            }
                Console.WriteLine();
            */


        }

    }
}
