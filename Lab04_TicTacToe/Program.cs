using System;
using Game = Lab04_TicTacToe.Classes.Game;
using Player = Lab04_TicTacToe.Classes.Player;


namespace Lab04_TicTacToe
{
    public class Program
    {

        static void Main(string[] args)
        {
            StartGame();
            Console.ReadKey();
        }

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
            Player p1 = new()
            {
                Name = "Josh",
                Marker = "X"
            };

            Player p2 = new()
            {
                Name = "Jared",
                Marker = "O"
            };


            Game game = new(p1, p2);

            Player winner = game.Play();

            if(winner.Marker == "Draw")
            {
                Console.WriteLine("Game over. We have a draw folks!");
            }
            else
            {
                Console.WriteLine($"Game over. {winner.Name} is the winner!");
            }
        }

    }
}