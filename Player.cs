using System.Collections.Generic;

namespace Courses_Final_Task_Sea_Battle
{
    internal class Player
    {
        private string nickname;
        private List<Ship> ships = new List<Ship>();
        public int[,] fieldWithShips = new int[10, 10];
        public int[,] fieldForEnemy = new int[10, 10];
        public Dictionary<int, int> availableShips = new Dictionary<int, int>();

        public Player(string name)
        {
            this.nickname = name;
            for (int i = 0; i < fieldWithShips.GetLength(0); i++)
            {
                for (int j = 0; j < fieldWithShips.GetLength(1); j++)
                {
                    fieldWithShips[i, j] = 0;
                }
            }
            for (int i = 0; i < fieldForEnemy.GetLength(0); i++)
            {
                for (int j = 0; j < fieldForEnemy.GetLength(1); j++)
                {
                    fieldForEnemy[i, j] = 0;
                }
            }
            availableShips.Add(1, 4);
            availableShips.Add(2, 3);
            availableShips.Add(3, 2);
            availableShips.Add(4, 1);
        }

        public string Nickname
        {
            get { return nickname; }
        }


        private bool CanPlaceShip(Ship ship)
        {
            bool result = false;
            if ((ship.X + ship.Length > 10 && ship.Direction) || (ship.Y + ship.Length > 10 && !ship.Direction))
            {
                return result;
            }
            if (ship.Direction)
            {
                if (ship.X == 0 && ship.Y == 0)
                {
                    for (int i = 0; i < ship.Length + 1; i++)
                    {
                        if (fieldWithShips[ship.X + i, ship.Y] == 0 && fieldWithShips[ship.X + i, ship.Y + 1] == 0)
                        {
                            result = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else if (ship.Y == 9 && ship.X == 9)
                {
                    for (int i = -1; i < ship.Length; i++)
                    {
                        if (fieldWithShips[ship.X + i, ship.Y] == 0 && fieldWithShips[ship.X + i, ship.Y - 1] == 0)
                        {
                            result = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else if (ship.X == 0 && ship.Y == 9)
                {
                    for (int i = 0; i < ship.Length + 1; i++)
                    {
                        if (fieldWithShips[ship.X + i, ship.Y] == 0 && fieldWithShips[ship.X + i, ship.Y - 1] == 0)
                        {
                            result = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else if (ship.X + ship.Length == 10 && ship.Y == 0)
                {
                    for (int i = -1; i < ship.Length; i++)
                    {
                        if (fieldWithShips[ship.X + i, ship.Y] == 0 && fieldWithShips[ship.X + i, ship.Y + 1] == 0)
                        {
                            result = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else if (ship.X + ship.Length == 10 && ship.Y == 9)
                {
                    for (int i = -1; i < ship.Length; i++)
                    {
                        if (fieldWithShips[ship.X + i, ship.Y] == 0 && fieldWithShips[ship.X + i, ship.Y - 1] == 0)
                        {
                            result = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else if (ship.X + ship.Length == 10)
                {
                    for (int i = -1; i < ship.Length; i++)
                    {
                        if (fieldWithShips[ship.X + i, ship.Y] == 0 && fieldWithShips[ship.X + i, ship.Y - 1] == 0
                            && fieldWithShips[ship.X + i, ship.Y + 1] == 0)
                        {
                            result = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else if (ship.X == 9)
                {
                    for (int i = -1; i < ship.Length; i++)
                    {
                        if (fieldWithShips[ship.X + i, ship.Y] == 0 && fieldWithShips[ship.X + i, ship.Y + 1] == 0
                            && fieldWithShips[ship.X + i, ship.Y - 1] == 0)
                        {
                            result = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else if (ship.X == 0)
                {
                    for (int i = 0; i < ship.Length + 1; i++)
                    {
                        if (fieldWithShips[ship.X + i, ship.Y] == 0 && fieldWithShips[ship.X + i, ship.Y + 1] == 0
                            && fieldWithShips[ship.X + i, ship.Y - 1] == 0)
                        {
                            result = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else if (ship.Y == 0)
                {
                    for (int i = -1; i < ship.Length + 1; i++)
                    {
                        if (fieldWithShips[ship.X + i, ship.Y] == 0 && fieldWithShips[ship.X + i, ship.Y + 1] == 0)
                        {
                            result = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else if (ship.Y == 9)
                {
                    for (int i = -1; i < ship.Length + 1; i++)
                    {
                        if (fieldWithShips[ship.X + i, ship.Y] == 0 && fieldWithShips[ship.X + i, ship.Y - 1] == 0)
                        {
                            result = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    for (int i = -1; i < ship.Length + 1; i++)
                    {
                        if (fieldWithShips[ship.X + i, ship.Y] == 0 && fieldWithShips[ship.X + i, ship.Y + 1] == 0
                            && fieldWithShips[ship.X + i, ship.Y - 1] == 0)
                        {
                            result = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            else
            {
                if (ship.X == 0 && ship.Y == 0)
                {
                    for (int i = 0; i < ship.Length + 1; i++)
                    {
                        if (fieldWithShips[ship.X, ship.Y + i] == 0 && fieldWithShips[ship.X + 1, ship.Y + i] == 0)
                        {
                            result = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else if (ship.Y == 9 && ship.X == 9)
                {
                    for (int i = -1; i < ship.Length; i++)
                    {
                        if (fieldWithShips[ship.X, ship.Y + i] == 0 && fieldWithShips[ship.X - 1, ship.Y + i] == 0)
                        {
                            result = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else if (ship.X == 9 && ship.Y == 0)
                {
                    for (int i = 0; i < ship.Length + 1; i++)
                    {
                        if (fieldWithShips[ship.X, ship.Y + i] == 0 && fieldWithShips[ship.X - 1, ship.Y + i] == 0)
                        {
                            result = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else if (ship.X == 0 && ship.Y + ship.Length == 10)
                {
                    for (int i = -1; i < ship.Length; i++)
                    {
                        if (fieldWithShips[ship.X, ship.Y + i] == 0 && fieldWithShips[ship.X + 1, ship.Y + i] == 0)
                        {
                            result = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else if (ship.X == 9 && ship.Y + ship.Length == 10)
                {
                    for (int i = -1; i < ship.Length; i++)
                    {
                        if (fieldWithShips[ship.X, ship.Y + i] == 0 && fieldWithShips[ship.X - 1, ship.Y + i] == 0)
                        {
                            result = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else if (ship.Y + ship.Length == 10)
                {
                    for (int i = -1; i < ship.Length; i++)
                    {
                        if (fieldWithShips[ship.X, ship.Y + i] == 0 && fieldWithShips[ship.X - 1, ship.Y + i] == 0
                            && fieldWithShips[ship.X + 1, ship.Y + i] == 0)
                        {
                            result = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else if (ship.Y == 9)
                {
                    for (int i = -1; i < ship.Length; i++)
                    {
                        if (fieldWithShips[ship.X, ship.Y + i] == 0 && fieldWithShips[ship.X + 1, ship.Y + i] == 0
                            && fieldWithShips[ship.X - 1, ship.Y + i] == 0)
                        {
                            result = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else if (ship.X == 0)
                {
                    for (int i = -1; i < ship.Length + 1; i++)
                    {
                        if (fieldWithShips[ship.X, ship.Y + i] == 0 && fieldWithShips[ship.X + 1, ship.Y + i] == 0)
                        {
                            result = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else if (ship.Y == 0)
                {
                    for (int i = 0; i < ship.Length + 1; i++)
                    {
                        if (fieldWithShips[ship.X, ship.Y + i] == 0 && fieldWithShips[ship.X + 1, ship.Y + i] == 0
                             && fieldWithShips[ship.X - 1, ship.Y + i] == 0)
                        {
                            result = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else if (ship.X == 9)
                {
                    for (int i = -1; i < ship.Length + 1; i++)
                    {
                        if (fieldWithShips[ship.X, ship.Y + i] == 0 && fieldWithShips[ship.X - 1, ship.Y + i] == 0)
                        {
                            result = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    for (int i = -1; i < ship.Length + 1; i++)
                    {
                        if (fieldWithShips[ship.X, ship.Y + i] == 0 && fieldWithShips[ship.X + 1, ship.Y + i] == 0
                             && fieldWithShips[ship.X - 1, ship.Y + i] == 0)
                        {
                            result = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            return result;
        }

        public bool Shot(int[] coords)
        {
            if (fieldWithShips[coords[0], coords[1]] == 1)
            {
                fieldForEnemy[coords[0], coords[1]] = -1;
                return true;
            }
            else if (fieldWithShips[coords[0], coords[1]] == 0)
            {
                fieldForEnemy[coords[0], coords[1]] = 2;
            }
            return false;
        }

        public bool AddShip(Ship newShip)
        {
            bool result = CanPlaceShip(newShip);
            if (result)
            {
                ships.Add(newShip);
                availableShips[newShip.Length]--;
                for (int i = 0; i < newShip.Length; i++)
                {
                    if (newShip.Direction)
                    {
                        fieldWithShips[newShip.X + i, newShip.Y] = 1;
                    }
                    else
                    {
                        fieldWithShips[newShip.X, newShip.Y + i] = 1;
                    }
                }
            }
            return result;
        }

        public bool UsedAllShips()
        {
            bool result = false;
            if (availableShips[1] == 0 && availableShips[1] == 0 && availableShips[3] == 0 && availableShips[4] == 0)
            {
                return true;
            }
            return result;
        }

        public bool HaveNoShips()
        {
            int counter = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (fieldForEnemy[i, j] == -1)
                    {
                        counter++;
                    }
                }
            }
            if (counter == 20)
            {
                return true;
            }
            return false;
        }
    }
}
