using System;
using System.Diagnostics;

namespace Lesson6
{
    class Program
    {
        /*
         * 
         * Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и
         * позволяет завершить указанный процесс. Предусмотреть возможность завершения процессов с
         * помощью указания его ID или имени процесса. В качестве примера можно использовать консольные
         * утилиты Windows tasklist и taskkill .
         * 
         */
        static void KillProcess(string choiceUser)
        {
            try
            {

                if (choiceUser == "ID" || choiceUser == "Id" || choiceUser == "id")
                {
                    Console.Write("\nВведите ID процесса которого хотели бы завершить:\t");
                    int IdProcess = int.Parse(Console.ReadLine());

                    foreach (Process process in Process.GetProcesses())
                    {
                        if (process.Id == IdProcess)
                            process.Kill();
                    }

                    Console.WriteLine("Процесс завершён. ");
                    ItsOk();

                }

                if (choiceUser == "Name" || choiceUser == "NAME" || choiceUser == "name")
                {
                    Console.Write("\nВведите имя процесса которого хотели бы завершить:\t");
                    string nameProcess = Console.ReadLine();

                    foreach (Process process in Process.GetProcesses())
                    {
                        if (process.ProcessName == nameProcess)
                            process.Kill();
                    }

                    Console.WriteLine("Процесс завершён. ");
                    ItsOk();

                }
                else
                {
                    Console.WriteLine("Ой ёй, что-то пошло не так! Вы ввели иные данные от предложенных.");

                    ItsOk();
                }
            }
            catch
            {
                Console.WriteLine("Произошла ошибка! Вы ввели не вверное значение или просто нажали Enter. Нажмите любую клавишу...");

                ItsOk();
            }


        }

        static void ShowProcess()
        {
            string id = "ID:";
            string name = "Name:";
            string memory = "Memory(byte):";

            Console.WriteLine("{0, -12} {1, -40} {2, -30} ", id, name, memory);
            Console.WriteLine("===================================================================");

            foreach (Process process in Process.GetProcesses())
            {
                Console.WriteLine("{0, -12} {1, -40} {2, -30} ", process.Id, process.ProcessName, process.VirtualMemorySize64);
            }

        }


        static void ItsOk()
        {
            try
            {
                Console.WriteLine("Нажмите любую клавишу...");
                Console.ReadKey();
                Console.Clear();
                int choice;

                Console.WriteLine("0 - Завершение работы");
                Console.WriteLine("1 - Повторить операцию");

                choice = Convert.ToInt32(Console.ReadLine());

                while (choice != 0)
                {
                    ShowProcess();

                    Console.Write("\nЗавершить процесс по номеру(ID) или имени(Name):\t");
                    string choiceUser = Console.ReadLine();

                    KillProcess(choiceUser);
                }

                Process.GetCurrentProcess().Kill();

            }
            catch
            {
                Console.WriteLine("Произошла ошибка! Вы ввели не вверное значение или просто нажали Enter. Нажмите любую клавишу...");

                ItsOk();
            }
        }


        static void Main(string[] args)
        {
            ShowProcess();

            Console.Write("\nЗавершить процесс по номеру(ID) или имени(Name):\t");
            string choiceUser = Console.ReadLine();

            KillProcess(choiceUser);
        }
    }
}
