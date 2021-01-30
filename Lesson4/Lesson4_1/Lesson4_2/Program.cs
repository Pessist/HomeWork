using System;
using System.Linq;

namespace Lesson4_2
{
    /*
     * 
     * Написать программу, принимающую на вход строку — набор чисел, 
     * разделенных пробелом, и возвращающую число — сумму всех чисел в строке. 
     * Ввести данные с клавиатуры и вывести результат на экран.
     * 
     * 
     */

    class Program
    {
        static int StringAllNambers(string stringValue)
        {
            Console.Write($"\nЭто уже идет вывод строки из вызванного нами метода, данные на вход: {stringValue}");

            string[] separateString = stringValue.Split(' '); //убираем пробелы в строке.

            int[] intValue = new int[separateString.Length]; // целочисленный массив для преобразования из строкового.

            //Преобразование массива из строкового в целочисленный
            Console.WriteLine("\n\nВывод массива преобразованного в числовой:");
            for (int i = 0; i < separateString.Length; i++)
            {
                intValue[i] = int.Parse(separateString[i]);
                Console.Write(intValue[i]);
            }

            int secondValue = intValue.Sum(); //Сумма всех цисел в массиве.

            return (secondValue);

        }

        static void Main(string[] args)
        {
            Console.Write("Введитет cтроку чисел разделенных пробелом: ");

            string strNambers = (Console.ReadLine());

            int result = StringAllNambers(strNambers);

            Console.WriteLine($"\n\nСумма всех цисел в массиве равна: {result}");

        }
    }
}
