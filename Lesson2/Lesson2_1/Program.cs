using System;

namespace lesson2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime thisToday = DateTime.Today;
            Console.Write("Здравствуйте. Сегодня " + thisToday.ToString("D") + " Введите, пожалуйста, минимальную температуру за сутки: ");
            string firstSetting = Console.ReadLine();
            double minTemp = Convert.ToDouble(firstSetting);

            Console.Write("А теперь введите максимальную температуру: ");
            string secondSetting = Console.ReadLine();
            double maxTemp = Convert.ToDouble(secondSetting);


            double meanTemp = (minTemp + maxTemp) / 2;

            Console.WriteLine($"Середнесуточная температура за сегодняшинй день = {meanTemp}");



        }
    }
}