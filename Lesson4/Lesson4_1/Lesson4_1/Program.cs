using System;

namespace Lesson4_1_V1
{
    class Program
    {
        /*
         * 
         * 
         * Написать метод GetFullName(string firstName, string lastName, string patronymic), 
         * принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО. 
         * Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.
         * 
         * 
         * 
         */

        //Данный способ я сделал изначально.

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            string name = lastName + " " + firstName + " " + patronymic;
            
            return (name);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте. Данная программа введёт журнал новых сотрудникв.");

            Console.WriteLine("Заводим первого человека:");
            Console.Write("Введите Фамилию: ");
            string lastNameOnePeople = Console.ReadLine();
            Console.Write("\nВведите имя: ");
            string firstNameOnePeople = Console.ReadLine();
            Console.Write("\nВведите отчество: ");
            string patronymicOnePeople = Console.ReadLine();

            Console.WriteLine("\nЗаводим второго человека:");
            Console.Write("Введите Фамилию: ");
            string lastNameTwoPeople = Console.ReadLine();
            Console.Write("\nВведите имя: ");
            string firstNameTwoPeople = Console.ReadLine();
            Console.Write("\nВведите отчество: ");
            string patronymicTwoPeople = Console.ReadLine();

            Console.WriteLine("\nЗаводим третьего человека:");
            Console.Write("Введите Фамилию: ");
            string lastNameThirdPeople = Console.ReadLine();
            Console.Write("\nВведите имя: ");
            string firstNameThirdPeople = Console.ReadLine();
            Console.Write("\nВведите отчество: ");
            string patronymicThirdPeople = Console.ReadLine();


            Console.WriteLine("Ввывод всей базы данных:");
            Console.WriteLine("Первый сотрудник: " + GetFullName(firstNameOnePeople, lastNameOnePeople, patronymicOnePeople));
            Console.WriteLine("Второй сотрудник: " + GetFullName(firstNameTwoPeople, lastNameTwoPeople, patronymicTwoPeople));
            Console.WriteLine("Второй сотрудник: " + GetFullName(firstNameThirdPeople, lastNameThirdPeople, patronymicThirdPeople));

        }
    }
}
