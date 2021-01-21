using System;

namespace lesson2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Здравствуйте, введите, пожалуйста, порядковый номер текущего месяца: ");
            string month = Console.ReadLine();
            int actualMounth = Convert.ToInt32(month);

            string nameMounth = "";

            switch (actualMounth)
            {
                case 1:
                    nameMounth = "Январь";
                    break;
                case 2:
                    nameMounth = "Февраль";
                    break;
                case 3:
                    nameMounth = "Март";
                    break;
                case 4:
                    nameMounth = "Апрель";
                    break;
                case 5:
                    nameMounth = "Май";
                    break;
                case 6:
                    nameMounth = "Июнь";
                    break;
                case 7:
                    nameMounth = "Июль";
                    break;
                case 8:
                    nameMounth = "Август";
                    break;
                case 9:
                    nameMounth = "Сентябрь";
                    break;
                case 10:
                    nameMounth = "Октябрь";
                    break;
                case 11:
                    nameMounth = "Ноябрь";
                    break;
                case 12:
                    nameMounth = "Декабь";
                    break;
            }

            Console.WriteLine($"На текущий мемент идёт месяц {nameMounth}");


        }
    }
}