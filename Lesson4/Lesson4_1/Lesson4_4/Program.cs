using System;

namespace Lesson4_4
{
    /*
     * 
     *4. (*) Написать программу, вычисляющую число Фибоначчи для заданного значения
     *  рекурсивным способом.
     *  Fn = Fn-1 + Fn-2 формула
     * 
     */


    class Program
    {

        static int Main(string[] args)
        {

            int number, i = 0;
            Console.Write("Введите число: ");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine("Ряд Фибоначчи\n");

            for (int j = 1; j <= number; j++)
            {
                int result = FibonacciFunction(i);
                Console.Write(result + " ");
                i++;
            }
            Console.WriteLine();
            return 0;
        }

        public static int FibonacciFunction(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return (FibonacciFunction(n - 1) + FibonacciFunction(n - 2));
            }
        }
    }
}
