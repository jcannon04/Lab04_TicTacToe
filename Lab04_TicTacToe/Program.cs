﻿using System;
using Board = Lab04_TicTacToe.Classes.Board;

namespace Lab04_TicTacToe
{
    public class Program
    {

        static void Main(string[] args)
        {
            StartGame();
        }

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
            Board board = new();
            board.DisplayBoard();
            Console.ReadLine();
        }


    }
}