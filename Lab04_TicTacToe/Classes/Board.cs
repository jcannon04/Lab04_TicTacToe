﻿namespace Lab04_TicTacToe.Classes
{
   public class Board
    {
        /// <summary>
        /// Tic Tac Toe Gameboard states
        /// </summary>
        public string[,] GameBoard = new string[,]
        {
            {"1", "2", "3"},
            {"4", "5", "6"},
            {"7", "8", "9"},
        };

        /// <summary>
        /// Display the Game Board
        /// </summary>
        public void DisplayBoard()
        {
            Console.WriteLine("");
            for (int i = 0; i < GameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < GameBoard.GetLength(1); j++)
                {
                    string position = GameBoard[i, j];

                    Console.Write($"|{position}|");

                    if (j == GameBoard.GetLength(1) - 1)
                    {
                        Console.WriteLine("");
                    }

                }
            }
            Console.WriteLine("");
        }
    }
}