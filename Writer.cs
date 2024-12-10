using System;
using System.Collections.Generic;

namespace Courses_Final_Task_Sea_Battle
{
    internal class Writer
    {
        public static void ShipCoordinats()
        {
            Console.WriteLine("Choose ship coordinats:");
            Console.WriteLine();
        }

        public static void ShipDirection()
        {
            Console.WriteLine("Choose ship position:");
            Console.WriteLine("To choose horisontal write - h");
            Console.WriteLine("To choose vertical write - v");
            Console.WriteLine();
        }

        public static void ChooseShipLength(Dictionary<int, int> availableShips)
        {
            Console.WriteLine("Choose ship length:");
            Console.WriteLine($"To choose ship with 1 board write - 1. You have {availableShips[1]} available 1 board ships");
            Console.WriteLine($"To choose ship with 2 boards write - 2. You have {availableShips[2]} available 2 board ships");
            Console.WriteLine($"To choose ship with 3 boards write - 3. You have {availableShips[3]} available 3 board ships");
            Console.WriteLine($"To choose ship with 4 boards write - 4. You have {availableShips[4]} available 4 board ships");
            Console.WriteLine();
        }

        public static void ErrorMessage(string message)
        {
            Console.WriteLine($"Error: {message}. Try again");
            Console.WriteLine();
        }

        public static void OnHitMessage(Player player)
        {
            Console.WriteLine($"{player.Nickname} hitted");
            Console.WriteLine();
            Console.ReadKey();
        }

        public static void OnMissMessage(Player player)
        {
            Console.WriteLine($"{player.Nickname} missed");
            Console.WriteLine();
            Console.ReadKey();
        }

        public static void TurnMessage(Player player)
        {
            Console.WriteLine($"{player.Nickname}'s turn");
            Console.WriteLine();
        }

        public static void WinMessage(Player player)
        {
            Console.WriteLine($"{player.Nickname.ToUpper()} WIN");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
