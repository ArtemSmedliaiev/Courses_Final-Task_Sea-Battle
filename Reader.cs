using System;
using System.Collections.Generic;

namespace Courses_Final_Task_Sea_Battle
{
    internal class Reader
    {
        public static int[] GetShipCoordinates()
        {
            Writer.ShipCoordinats();
            for (; ; )
            {
                try
                {
                    string input = Console.ReadLine();
                    int[] coords = new int[2];

                    if ((input.Length == 2 || input.Length == 3) && (input.Contains("A") || input.Contains("B") || input.Contains("C") || input.Contains("D")
                        || input.Contains("E") || input.Contains("F") || input.Contains("G") || input.Contains("H") || input.Contains("I")
                        || input.Contains("J")))
                    {
                        char letter = input[0];
                        int numberPart = Convert.ToInt32(input.Substring(1));
                        int letterPart = letter - 'A' + 1;
                        if (numberPart > 0 && numberPart <= 10)
                        {
                            coords[0] = numberPart - 1;
                            coords[1] = letterPart - 1;
                            return coords;
                        }
                        else
                        {
                            Writer.ErrorMessage("incorrect input");
                        }
                    }
                    else
                    {
                        Writer.ErrorMessage("incorrect input");
                    }
                }
                catch (Exception e)
                {
                    Writer.ErrorMessage(e.Message);
                    continue;
                }
            }
        }

        public static bool GetShipDirection()
        {
            Writer.ShipDirection();

            for (; ; )
            {
                string direction = Console.ReadLine();
                if (direction == "h")
                {
                    return true;
                }
                else if (direction == "v")
                {
                    return false;
                }
                Writer.ErrorMessage("wrong direction");
            }
        }

        public static int GetShipLength(Dictionary<int, int> availableShips)
        {
            Writer.ChooseShipLength(availableShips);
            int length = 0;
            for (; ; )
            {
                if (Int32.TryParse(Console.ReadLine(), out length) && (length >= 1 && length <= 4))
                {
                    if (availableShips[length] != 0)
                    {
                        return length;
                    }
                    else
                    {
                        Writer.ErrorMessage("you cannot place this length ships anymore");
                    }
                }
                else
                {
                    Writer.ErrorMessage("incorrect input");
                }
            }
        }
    }
}
