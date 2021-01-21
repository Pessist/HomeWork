using System;

namespace lesson2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime thisToday = DateTime.Today;
            Console.Write("Здравствуйте. Введите, пожалуйста, минимальную температуру за сутки: ");
            string firstSetting = Console.ReadLine();
            double minTemp = Convert.ToDouble(firstSetting);

            Console.Write("А теперь введите максимальную температуру: ");
            string secondSetting = Console.ReadLine();
            double maxTemp = Convert.ToDouble(secondSetting);


            double meanTemp = (minTemp + maxTemp) / 2;

            Console.WriteLine($"Середнесуточная температура за сегодняшинй день = {meanTemp}");

            Console.Write("Введите, пожалуйста, порядковый номер текущего месяца: ");


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

            bool winter = nameMounth == "Декабрь" || nameMounth == "Январь" || nameMounth == "Февраль";
            bool boolMeanTemp = meanTemp > 0;

            if (winter && boolMeanTemp)
                Console.WriteLine("Дождливая зима, однако!");
            else
                Console.WriteLine($"На дворе {nameMounth}, среднесуточная тепература {meanTemp}. А споносор выпуска погоды - хорошее настроение! :-)");

            }
    }
}