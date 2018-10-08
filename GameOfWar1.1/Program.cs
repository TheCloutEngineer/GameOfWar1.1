using System;

namespace GameOfWar1._1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game("Khalil","Deacom");
            while (!game.IsGameOver())
            {
                game.PlayTurn();
            }

            Console.Read();
        }
    }
}