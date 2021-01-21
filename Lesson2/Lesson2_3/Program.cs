using System;

namespace Lesson2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите чило: ");
            string firstNumber = Console.ReadLine();
            double number = Convert.ToDouble(firstNumber);
            double even = number % 2;

            if (even == 0)
                Console.WriteLine("Введенное Вами число является четным!");
            else
                Console.WriteLine("Введенное Вами число не четное!");
        }
    }
}
