using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstGreeting = Properties.Settings.Default.FirstGreeting;
            Console.WriteLine($"{firstGreeting}\n");

            string userName, greeting, profession;
            int age;

            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                Console.WriteLine("Введите имя пользователя:");
                Properties.Settings.Default.UserName = Console.ReadLine();

                Console.WriteLine("\nВведите Ваш возраст:");
                Properties.Settings.Default.Age = int.Parse(Console.ReadLine());

                Console.WriteLine("\nВведите Ваш род деятельности:");
                Properties.Settings.Default.WhatProfession = Console.ReadLine();

                Properties.Settings.Default.Save();

                userName = Properties.Settings.Default.UserName;
                greeting = Properties.Settings.Default.Greeting;
                age = Properties.Settings.Default.Age;
                profession = Properties.Settings.Default.WhatProfession;
                Console.WriteLine($"\n{greeting}, {userName}!");
                Console.WriteLine($"Возраст: {age}, род деятельности: {profession}!");
            }
            else
            {
                userName = Properties.Settings.Default.UserName;
                greeting = Properties.Settings.Default.Greeting;
                age = Properties.Settings.Default.Age;
                profession = Properties.Settings.Default.WhatProfession;
                Console.WriteLine($"{greeting}, {userName}! \nВозраст: {age}, род деятельности: {profession}");
            }
        }
    }
}
