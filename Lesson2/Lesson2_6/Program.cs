using System;
namespace lesson2_6
{
    class Program
    {
        [Flags]
        public enum Weekday
        {

            Monday = 0b_0000001,
            Tuesday = 0b_0000010,
            Wednesday = 0b_0000100,
            Thursday = 0b_0001000,
            Friday = 0b_0010000,
            Saturday = 0b_0100000,
            Sunday = 0b_1000000,

        }

        static void Main(string[] args)
        {
            Weekday ClinicPlasticSurgery = Weekday.Monday | Weekday.Tuesday | Weekday.Wednesday | Weekday.Thursday | Weekday.Friday;
            Weekday PaidPolyclinic = Weekday.Monday | Weekday.Tuesday | Weekday.Thursday | Weekday.Friday | Weekday.Saturday | Weekday.Sunday;
            Weekday ClinicCosmetoloqy = Weekday.Monday | Weekday.Tuesday | Weekday.Wednesday | Weekday.Saturday | Weekday.Sunday;

            Console.WriteLine("Время работы пластической хирургии: " + ClinicPlasticSurgery);
            Console.WriteLine("Время работы платной поликлиники: " + PaidPolyclinic);
            Console.WriteLine("Время работы косметологии: " + ClinicCosmetoloqy);
                    
            //Свободные дни у человека с именем Нина
            Weekday freeDayNina = (Weekday)0b_1110011;



            Console.WriteLine($"В эти дни Нина может посетить Пластическую хирургию: {ClinicPlasticSurgery & freeDayNina}");
            Console.WriteLine($"В эти дни Нина может посетить Платную поликлинику: {PaidPolyclinic & freeDayNina}");
            Console.WriteLine($"В эти дни Нина может посетить  Косметологию: {PaidPolyclinic & freeDayNina}");
            
          
        }
    }
}
