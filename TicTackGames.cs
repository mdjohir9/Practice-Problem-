using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consol_practise_app
{
    public class TicTackGames
    {
        public char[,] board = new char[3, 3];
         public char currentPlayer;

        // Initialize the board
      public  void InitializeBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';
                }
            }
            currentPlayer = 'X';
        }

        // Print the board
      public  void PrintBoard()
        {
            Console.WriteLine();
            Console.WriteLine($" {board[0, 0]} | {board[0, 1]} | {board[0, 2]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[1, 0]} | {board[1, 1]} | {board[1, 2]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {board[2, 0]} | {board[2, 1]} | {board[2, 2]} ");
            Console.WriteLine();
        }

        // Check winner
        public bool CheckWinner()
        {
            // Rows
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == currentPlayer &&
                    board[i, 1] == currentPlayer &&
                    board[i, 2] == currentPlayer)
                    return true;
            }

            // Columns
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == currentPlayer &&
                    board[1, i] == currentPlayer &&
                    board[2, i] == currentPlayer)
                    return true;
            }

            // Diagonals
            if (board[0, 0] == currentPlayer &&
                board[1, 1] == currentPlayer &&
                board[2, 2] == currentPlayer)
                return true;

            if (board[0, 2] == currentPlayer &&
                board[1, 1] == currentPlayer &&
                board[2, 0] == currentPlayer)
                return true;

            return false;
        }

        // Check if board is full
        public bool IsBoardFull()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == ' ')
                        return false;
                }
            }
            return true;
        }

        // Switch player
        public void SwitchPlayer()
        {
            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
        }

        // Player Move
        public void PlayerMove()
        {
            int row, col;

            while (true)
            {
                Console.Write($"Player {currentPlayer}, enter row and column (0-2): ");
                string input = Console.ReadLine();
                string[] parts = input.Split(' ');

                if (parts.Length != 2 ||
                    !int.TryParse(parts[0], out row) ||
                    !int.TryParse(parts[1], out col))
                {
                    Console.WriteLine("Invalid input! Enter numbers like: 1 2");
                    continue;
                }

                if (row < 0 || row > 2 || col < 0 || col > 2)
                {
                    Console.WriteLine("Invalid position! Try again.");
                }
                else if (board[row, col] != ' ')
                {
                    Console.WriteLine("Cell already taken! Try again.");
                }
                else
                {
                    board[row, col] = currentPlayer;
                    break;
                }
            }
        }



    }
}
