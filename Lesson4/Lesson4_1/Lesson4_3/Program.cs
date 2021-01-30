using System;

namespace Lesson4_3
{
    class Program
    {
        /*
         * 
         *3. Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца. 
         *На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn. 
         *Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года 
         *(зима, весна, лето, осень). Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года. 
         *Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».
         * 
         */

        [Flags]
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        static string timeYear(int numberMounth)
        {
            string whatIsNow;
            switch (numberMounth)
            {
                case 1:
                    Season currentSeason = Season.Winter;
                    whatIsNow = Convert.ToString(currentSeason);
                    return whatIsNow;
                    break;
                case 2:
                    currentSeason = Season.Winter;
                    whatIsNow = Convert.ToString(currentSeason);
                    return whatIsNow;
                    break;
                case 3:
                    currentSeason = Season.Spring;
                    whatIsNow = Convert.ToString(currentSeason);
                    return whatIsNow;
                    break;
                case 4:
                    currentSeason = Season.Spring;
                    whatIsNow = Convert.ToString(currentSeason);
                    return whatIsNow;
                    break;
                case 5:
                    currentSeason = Season.Spring;
                    whatIsNow = Convert.ToString(currentSeason);
                    return whatIsNow;
                    break;
                case 6:
                    currentSeason = Season.Summer;
                    whatIsNow = Convert.ToString(currentSeason);
                    return whatIsNow;
                    break;
                case 7:
                    currentSeason = Season.Summer;
                    whatIsNow = Convert.ToString(currentSeason);
                    return whatIsNow;
                    break;
                case 8:
                    currentSeason = Season.Summer;
                    whatIsNow = Convert.ToString(currentSeason);
                    return whatIsNow;
                    break;
                case 9:
                    currentSeason = Season.Autumn;
                    whatIsNow = Convert.ToString(currentSeason);
                    return whatIsNow;
                    break;
                case 10:
                    currentSeason = Season.Autumn;
                    whatIsNow = Convert.ToString(currentSeason);
                    return whatIsNow;
                    break;
                case 11:
                    currentSeason = Season.Autumn;
                    whatIsNow = Convert.ToString(currentSeason);
                    return whatIsNow;
                    break;
                case 12:
                    currentSeason = Season.Winter;
                    whatIsNow = Convert.ToString(currentSeason);
                    return whatIsNow;
                    break;
                default:
                    whatIsNow = "Ошибка: введите число от 1 до 12";
                    return whatIsNow;
            }

        }

        static void Main(string[] args)
        {
            Console.Write("Введите число месяца: ");

            int numberMounth = int.Parse(Console.ReadLine());

            string result = timeYear(numberMounth);

            Console.WriteLine($"\nТекущий сезон: {result}");

        }
    }
}
