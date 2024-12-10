using System;

namespace Courses_Final_Task_Sea_Battle
{
    internal class FieldsPrinter
    {
        public static void PrintEmptyFields()
        {
            Console.WriteLine("   A B C D E F G H I J\t   A B C D E F G H I J");
            Console.WriteLine(" 1 0 0 0 0 0 0 0 0 0 0\t 1 0 0 0 0 0 0 0 0 0 0");
            Console.WriteLine(" 2 0 0 0 0 0 0 0 0 0 0\t 2 0 0 0 0 0 0 0 0 0 0");
            Console.WriteLine(" 3 0 0 0 0 0 0 0 0 0 0\t 3 0 0 0 0 0 0 0 0 0 0");
            Console.WriteLine(" 4 0 0 0 0 0 0 0 0 0 0\t 4 0 0 0 0 0 0 0 0 0 0");
            Console.WriteLine(" 5 0 0 0 0 0 0 0 0 0 0\t 5 0 0 0 0 0 0 0 0 0 0");
            Console.WriteLine(" 6 0 0 0 0 0 0 0 0 0 0\t 6 0 0 0 0 0 0 0 0 0 0");
            Console.WriteLine(" 7 0 0 0 0 0 0 0 0 0 0\t 7 0 0 0 0 0 0 0 0 0 0");
            Console.WriteLine(" 8 0 0 0 0 0 0 0 0 0 0\t 8 0 0 0 0 0 0 0 0 0 0");
            Console.WriteLine(" 9 0 0 0 0 0 0 0 0 0 0\t 9 0 0 0 0 0 0 0 0 0 0");
            Console.WriteLine("10 0 0 0 0 0 0 0 0 0 0\t10 0 0 0 0 0 0 0 0 0 0");
            Console.WriteLine();
        }

        public static void FieldsUpdate(Player firstPlayer, Player secondPlayer)
        {
            Console.Clear();
            Console.WriteLine("   A B C D E F G H I J       A B C D E F G H I J");
            for (int i = 0; i < 9; i++)
            {
                Console.Write($" {i + 1}");
                for (int j = 0; j < 10; j++)
                {
                    if (firstPlayer.fieldForEnemy[i, j] == -1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" x");
                        Console.ResetColor();
                    }
                    else if (firstPlayer.fieldForEnemy[i, j] == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(" m");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(" 0");
                    }

                }
                Console.Write($"\t   {i + 1}");
                for (int j = 0; j < 10; j++)
                {
                    if (secondPlayer.fieldForEnemy[i, j] == -1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(" x");
                        Console.ResetColor();
                    }
                    else if (secondPlayer.fieldForEnemy[i, j] == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(" m");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(" 0");
                    }
                }
                Console.WriteLine();
            }
            Console.Write("10");
            for (int i = 0; i < 10; i++)
            {
                if (firstPlayer.fieldForEnemy[9, i] == -1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" x");
                    Console.ResetColor();
                }
                else if (firstPlayer.fieldWithShips[9, i] == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" m");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(" 0");
                }
            }
            Console.Write("    10");
            for (int i = 0; i < 10; i++)
            {
                if (secondPlayer.fieldForEnemy[9, i] == -1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" x");
                    Console.ResetColor();
                }
                else if (secondPlayer.fieldForEnemy[9, i] == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" m");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(" 0");
                }
            }
            Console.WriteLine();
        }

        public static void PlayerField(Player player)
        {
            Console.Clear();
            Console.WriteLine("   A B C D E F G H I J");
            for (int i = 0; i < 9; i++)
            {
                Console.Write($" {i + 1}");
                for (int j = 0; j < 10; j++)
                {
                    if (player.fieldWithShips[j, i] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write($" {player.fieldWithShips[j, i]}");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            Console.Write("10");
            for (int i = 0; i < 10; i++)
            {
                if (player.fieldWithShips[i, 9] == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.Write($" {player.fieldWithShips[i, 9]}");
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
