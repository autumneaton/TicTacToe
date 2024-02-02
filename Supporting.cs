using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Supporting
    {
        private const int Size = 3; // The size of one side of the Tic Tac Toe board

        // Method to print the current state of the 1D array: tictactoeArray
        public void PrinttictactoeArray(string[] tictactoeArray)
        {
            for (int iCount = 0; iCount < tictactoeArray.Length; iCount++)
            {
                Console.Write(tictactoeArray[iCount]);
                if ((iCount + 1) % Size != 0)
                {
                    Console.Write(" | ");
                }
                else if (iCount < tictactoeArray.Length - 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("---------");
                }
            }
            Console.WriteLine();
        }

        // Method to determine if there is a winner or the game is a draw
        public string CheckForWinner(string[] tictactoeArray)
        {
            // Check rows and columns for a winner
            for (int iCount = 0; iCount < Size; iCount++)
            {
                // Check rows
                if (AreAllEqual(tictactoeArray[iCount * Size], tictactoeArray[iCount * Size + 1], tictactoeArray[iCount * Size + 2]))
                {
                    return $"{tictactoeArray[iCount * Size]} wins!";
                }
                // Check columns
                if (AreAllEqual(tictactoeArray[iCount], tictactoeArray[iCount + Size], tictactoeArray[iCount + 2 * Size]))
                {
                    return $"{tictactoeArray[iCount]} wins!";
                }
            }

            // Check diagonals for a winner
            if (AreAllEqual(tictactoeArray[0], tictactoeArray[4], tictactoeArray[8]) || AreAllEqual(tictactoeArray[2], tictactoeArray[4], tictactoeArray[6]))
            {
                return $"{tictactoeArray[4]} wins!";
            }

            // Check for a draw
            if (IsTictactoeArrayFull(tictactoeArray))
            {
                return "It's a draw!";
            }

            // No winner yet
            return null;
        }

        private bool AreAllEqual(string a, string b, string c)
        {
            return a == b && b == c && a != " ";
        }


        // Helper method to check if the tictactoeArray is full
        private bool IsTictactoeArrayFull(string[] tictactoeArray)
        {
            for (int iCount = 0; iCount < tictactoeArray.Length; iCount++)
            {
                if (tictactoeArray[iCount] == " ")
                {
                    return false;
                }
            }
            return true;
        }
    }

}
