namespace Courses_Final_Task_Sea_Battle
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Player1");
            Player player2 = new Player("Player2");
            //int[,] board = new int[10, 10]
            //{
            //    {1, 1, 0, 0, 0, 0, 0, 1, 1, 0}, 
            //    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            //    {0, 0, 1, 1, 0, 0, 0, 0, 0, 0}, 
            //    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            //    {0, 1, 0, 0, 0, 1, 1, 1, 1, 0}, 
            //    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            //    {0, 0, 0, 1, 0, 0, 0, 0, 0, 0}, 
            //    {0, 1, 0, 0, 0, 0, 1, 1, 1, 0}, 
            //    {0, 1, 0, 0, 0, 0, 0, 0, 0, 0},
            //    {0, 1, 0, 0, 1, 0, 0, 0, 0, 1}, 
            //};
            //player1.fieldWithShips = board;
            //player2.fieldWithShips = board;
            Game game = new Game(player1, player2);
            game.GameStart();
            game.Fight();
        }
    }
}
