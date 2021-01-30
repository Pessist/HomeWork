using System;

namespace Lesson4_1_V2
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
    class Program
    {
        //Данное решения я взял с методички пытался рабораться.
        static void Main(string[] args)
        {
            (string firstName, string lastName, string patronymic)[] fullName = CreateFullName();
            ShowMenu(fullName);
        }

        static (string firstName, string lastName, string patronymic)[] CreateFullName()
        {
            Console.WriteLine("Здравствуйте. Данная программа введёт журнал новых сотрудникв.");

            Console.WriteLine("Введите количество людей:");
            int count = ReadInt();
            (string firstName, string lastName, string patronymic)[] fullName =
                new (string firstName, string lastName, string patronymic)[count];
            for (int i = 0; i < fullName.Length; i++)
            {
                fullName[i] = CreateUser();
                Console.WriteLine($"Пользователь {FormatUserData(fullName[i])} сохранен");
            }
            Console.WriteLine("Ввод данных завершён. Нажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();
            return fullName;
        }

        static void ShowMenu((string firstName, string lastName, string patronymic)[] fullName)
        {
            int choice;
            do
            {
                choice = GetUserChoice();
                switch (choice)
                {
                    case 0: return;
                    case 1:
                        PrintUsers(fullName);
                        break;
                    case 2:
                        PrintSelectedUser(fullName);
                        break;
                    default:
                        break;
                }
            } while (choice != 0);
        }
        static (string firstName, string lastName, string patronymic) CreateUser()
        {

            Console.Write("Введите Фамилию: ");
            string lastName = Console.ReadLine();
            Console.Write("\nВведите имя: ");
            string firstName = Console.ReadLine();
            Console.Write("\nВведите отчество: ");
            string patronymic = Console.ReadLine();

            return (firstName, lastName, patronymic);
        }
        static int GetUserChoice()
        {
            Console.WriteLine("0 - Завершение работы");
            Console.WriteLine("1 - Просмотр всей базы данных");
            Console.WriteLine("2 - Просмотр пользователя");
            return ReadInt();
        }

        static void PrintSelectedUser((string firstName, string lastName, string patronymic)[] fullName)
        {
            int userIndex;
            do
            {
                Console.WriteLine($"Введите идентификатор пользователя - от 0 до { fullName.Length - 1}");
                userIndex = ReadInt();
            } while (userIndex < 0 || userIndex >= fullName.Length);
            PrintUser(fullName[userIndex]);
        }
        static void PrintUsers((string firstName, string lastName, string patronymic)[] fullName)
        {
            Console.WriteLine("Вывод базы данных:");
            for (int i = 0; i < fullName.Length; i++)
            {
                PrintUser(fullName[i]);
            }
        }

        static void PrintUser((string firstName, string lastName, string patronymic) fullName)
        {
            Console.WriteLine(FormatUserData(fullName));
        }
        static string FormatUserData((string firstName, string lastName, string patronymic) fullName)
        {
            return $"{fullName.lastName} {fullName.firstName} { fullName.patronymic}";
        }
        static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
