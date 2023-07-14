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
            Console.Write("Player 1 Name: ");
            string p1Name = Console.ReadLine();
            Console.Write("Player 2 Name: ");
            string p2Name = Console.ReadLine();

            Player p1 = new()
            {
                Name = p1Name,
                Marker = "X"
            };

            Player p2 = new()
            {
                Name = p2Name,
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