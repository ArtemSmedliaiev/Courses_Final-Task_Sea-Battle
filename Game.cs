using System;

namespace Courses_Final_Task_Sea_Battle
{
    internal class Game
    {
        private Player currentPlayer;
        private Player waitingPlayer;
        private Player firstPlayer;
        private Player secondPlayer;

        public Game(Player player1, Player player2)
        {
            firstPlayer = player1;
            secondPlayer = player2;
            currentPlayer = player1;
            waitingPlayer = player2;
        }

        public void GameStart()
        {
            ShipPlacing();
            ShipPlacing();
            FieldsPrinter.PrintEmptyFields();
        }

        public void Fight()
        {
            do
            {
                FieldsPrinter.FieldsUpdate(firstPlayer, secondPlayer);
                Writer.TurnMessage(currentPlayer);
                if (waitingPlayer.Shot(Reader.GetShipCoordinates()))
                {
                    Writer.OnHitMessage(currentPlayer);
                }
                else
                {
                    Writer.OnMissMessage(currentPlayer);
                    TurnChange();
                }
            } while (!waitingPlayer.HaveNoShips());
            Writer.WinMessage(currentPlayer);
        }

        private void ShipPlacing()
        {
            do
            {
                FieldsPrinter.PlayerField(currentPlayer);
                Writer.TurnMessage(currentPlayer);
                if (!currentPlayer.AddShip(ShipCreating()))
                {
                    Writer.ErrorMessage("ship was not added");
                    Console.ReadKey();
                }
                FieldsPrinter.PlayerField(currentPlayer);
            } while (!currentPlayer.UsedAllShips());
            TurnChange();
        }

        private Ship ShipCreating()
        {
            int shipLength = Reader.GetShipLength(currentPlayer.availableShips);
            bool shipDirection = Reader.GetShipDirection();
            int[] coords = Reader.GetShipCoordinates();
            return new Ship(shipLength, coords[0], coords[1], shipDirection);
        }

        private void TurnChange()
        {
            Player player = currentPlayer;
            currentPlayer = waitingPlayer;
            waitingPlayer = player;
        }
    }
}

