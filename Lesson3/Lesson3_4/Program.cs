using System;

namespace Lesson3_4
{
    class Program
    {
        /* Задание:
         * 
         * 4. * «Морской бой» — вывести на экран массив 10х10, 
         * состоящий из символов X и O, где Х — элементы кораблей,
         * а О — свободные клетки.
         * 
         * */


        static void Main(string[] args)
        {
            int x, y, orientation; // X,Y - координаты и оринетация расположения коробля.
            int countShip = 0; //Счётчик установленных караблей.

            Random random = new Random();

            char[,] gameBoard = new char[10, 10]; //Думерный массив игрового поля.

            Console.WriteLine("Вывод данных двумерного массива:");


            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoard.GetLength(1); j++)
                {
                    gameBoard[j, i] = 'O';
                    Console.Write(" ");
                    Console.Write(gameBoard[j, i]);
                }

                Console.WriteLine();
            }

            //Строим четырёхпалубный корабль
            while (countShip < 1)
            {
                // рандоные значения установки коробля и в каком направлении.
                orientation = random.Next(4);
                x = random.Next(10);
                y = random.Next(10);

                //Сохраняем значения во временные переменные, для возращения после этапа проверки.
                int temp_x = x;
                int temp_y = y;

                //Проверка возможности расстановки корабля.
                bool settingPossible = true;

                for (int i = 0; i < 4; i++)
                {
                    //Проверка не выходи ли за пределы массива при проприсовки наш корабль
                    
                    if (x < 0 || y < 0 || x > gameBoard.GetLength(0) - 1  || y > gameBoard.GetLength(1) -1)
                    {
                        settingPossible = false;
                        break;
                    }

                    switch (orientation)
                    {
                        case 0:
                            x++;
                            break;
                        case 1:
                            y++;
                            break;
                        case 2:
                            x--;
                            break;
                        case 3:
                            y--;
                            break;
                    }
                }

                //Если проверка прошла успешно то рисуем кораблик.
                if (settingPossible == true)
                {
                    x = temp_x;
                    y = temp_y;

                    // Макет однопалубного коробля.
                    for (int i = 0; i < 4; i++)
                    {
                        gameBoard[x, y] = 'X';

                        switch (orientation)
                        {
                            case 0:
                                x++;
                                break;
                            case 1:
                                y++;
                                break;
                            case 2:
                                x--;
                                break;
                            case 3:
                                y--;
                                break;
                        }

                    }

                    countShip++;

                }
            }

            //Строим два трехпалубных корабля
            countShip = 0;

            while (countShip < 2)
            {
                // рандоные значения установки коробля и в каком направлении.
                orientation = random.Next(4);
                x = random.Next(10);
                y = random.Next(10);

                //Сохраняем значения во временные переменные, для возращения после этапа проверки.
                int temp_x = x;
                int temp_y = y;

                //Проверка возможности расстановки корабля.

                bool settingPossible = true;

                for (int i = 0; i < 3; i++)
                {
                    //Проверка не выходи ли за пределы массива при проприсовки наш корабль

                    if (x < 0 || y < 0 || x > gameBoard.GetLength(0) - 1 || y > gameBoard.GetLength(1) - 1)
                    {
                        settingPossible = false;
                        break;
                    }

                    switch (orientation)
                    {
                        case 0:
                            x++;
                            break;
                        case 1:
                            y++;
                            break;
                        case 2:
                            x--;
                            break;
                        case 3:
                            y--;
                            break;
                    }
                }

                //Если проверка прошла успешно то рисуем кораблик.
                if (settingPossible == true)
                {
                    x = temp_x;
                    y = temp_y;

                    // Макет однопалубного коробля.
                    for (int i = 0; i < 3; i++)
                    {

                        gameBoard[x, y] = 'X';

                        switch (orientation)
                        {
                            case 0:
                                x++;
                                break;
                            case 1:
                                y++;
                                break;
                            case 2:
                                x--;
                                break;
                            case 3:
                                y--;
                                break;
                        }

                    }

                    countShip++;

                }
            }

            //Строим три двухпалубных корабля
            countShip = 0;

            while (countShip < 3)
            {
                // рандоные значения установки коробля и в каком направлении.
                orientation = random.Next(4);
                x = random.Next(10);
                y = random.Next(10);

                //Сохраняем значения во временные переменные, для возращения после этапа проверки.
                int temp_x = x;
                int temp_y = y;

                //Проверка возможности расстановки корабля.


                bool settingPossible = true;

                for (int i = 0; i < 2; i++)
                {
                    //Проверка не выходи ли за пределы массива при проприсовки наш корабль

                    if (x < 0 || y < 0 || x > gameBoard.GetLength(0) - 1 || y > gameBoard.GetLength(1) - 1)
                    {
                        settingPossible = false;
                        break;
                    }

                    switch (orientation)
                    {
                        case 0:
                            x++;
                            break;
                        case 1:
                            y++;
                            break;
                        case 2:
                            x--;
                            break;
                        case 3:
                            y--;
                            break;
                    }
                }

                //Если проверка прошла успешно то рисуем кораблик.
                if (settingPossible == true)
                {
                    x = temp_x;
                    y = temp_y;

                    // Макет однопалубного коробля.
                    for (int i = 0; i < 2; i++)
                    {

                        gameBoard[x, y] = 'X';

                        switch (orientation)
                        {
                            case 0:
                                x++;
                                break;
                            case 1:
                                y++;
                                break;
                            case 2:
                                x--;
                                break;
                            case 3:
                                y--;
                                break;
                        }

                    }

                    countShip++;

                }
            }

            //Строим четыре однопалубных корабля

            countShip = 0;

            while (countShip < 4)
            {
                // рандоные значения установки коробля и в каком направлении.
                orientation = random.Next(4);
                x = random.Next(10);
                y = random.Next(10);

                //Сохраняем значения во временные переменные, для возращения после этапа проверки.
                int temp_x = x;
                int temp_y = y;

                //Проверка возможности расстановки корабля.


                bool settingPossible = true;

                for (int i = 0; i < 1; i++)
                {
                    //Проверка не выходи ли за пределы массива при проприсовки наш корабль

                    if (x < 0 || y < 0 || x > gameBoard.GetLength(0) - 1 || y > gameBoard.GetLength(1) - 1)
                    {
                        settingPossible = false;
                        break;
                    }

                    switch (orientation)
                    {
                        case 0:
                            x++;
                            break;
                        case 1:
                            y++;
                            break;
                        case 2:
                            x--;
                            break;
                        case 3:
                            y--;
                            break;
                    }
                }

                //Если проверка прошла успешно то рисуем кораблик.
                if (settingPossible == true)
                {
                    x = temp_x;
                    y = temp_y;

                    // Макет однопалубного коробля.
                    for (int i = 0; i < 1; i++)
                    {

                        gameBoard[x, y] = 'X';

                        switch (orientation)
                        {
                            case 0:
                                x++;
                                break;
                            case 1:
                                y++;
                                break;
                            case 2:
                                x--;
                                break;
                            case 3:
                                y--;
                                break;
                        }

                    }

                    countShip++;

                }
            }

            Console.WriteLine("\nВывод данных двумерного массива:");

            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoard.GetLength(1); j++)
                {

                        Console.Write(" ");
                        Console.Write(gameBoard[j, i]);

                }

                Console.WriteLine();
            }


        }
    }
}
