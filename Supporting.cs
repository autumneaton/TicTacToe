using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Supporting
    {
        // Method to print the current state of the 2 dimmensional array: tictactoeArray
        public void PrinttictactoeArray(char[,] tictactoeArray)
        {
            for (int iCountOuter = 0; iCountOuter < tictactoeArray.GetLength(0); iCountOuter++)
            {
                for (int iCountInner = 0; iCountInner < tictactoeArray.GetLength(1); iCountInner++)
                {
                    Console.Write(tictactoeArray[iCountOuter, iCounterInner]);
                    if (iCountInner < tictactoeArray.GetLength(1) - 1)
                    {
                        Console.Write(" | ");
                    }
                }
                Console.WriteLine();
                if (iCountOuter < tictactoeArray.GetLength(0) - 1)
                {
                    Console.WriteLine("---------");
                }
            }
        }

        // Method to determine if there is a winner or the game is a draw
        public string CheckForWinner(char[,] tictactoeArray)
        {
            // Check rows and columns for a winner
            for (int iCountOuter = 0; iCountOuter < 3; iCountOuter++)
            {
                if (AreAllEqual(tictactoeArray[iCountOuter, 0], tictactoeArray[iCountOuter, 1], tictactoeArray[iCountOuter, 2]))
                {
                    return $"{tictactoeArray[iCountOuter, 0]} wins!";
                }
                if (AreAllEqual(tictactoeArray[0, iCountOuter], tictactoeArray[1, iCountOuter], tictactoeArray[2, iCountOuter]))
                {
                    return $"{tictactoeArray[0, iCountOuter]} wins!";
                }
            }

            // Check diagonals for a winner
            if (AreAllEqual(tictactoeArray[0, 0], tictactoeArray[1, 1], tictactoeArray[2, 2]) || AreAllEqual(tictactoeArray[0, 2], tictactoeArray[1, 1], tictactoeArray[2, 0]))
            {
                return $"{tictactoeArray[1, 1]} wins!";
            }

            // Check for a draw
            if (IstictactoeArrayFull(tictactoeArray))
            {
                return "It's a draw!";
            }

            // No winner yet
            return null;
        }

        // Helper method to check if all three characters are equal and not empty
        private bool AreAllEqual(char a, char b, char c)
        {
            return a == b && b == c && a != ' ';
        }

        // Helper method to check if the tictactoeArray is full
        private bool IstictactoeArrayFull(char[,] tictactoeArray)
        {
            for (int iCountOuter = 0; iCountOuter < tictactoeArray.GetLength(0); iCountOuter++)
            {
                for (int iCountInner = 0; iCountInner < tictactoeArray.GetLength(1); iCountInner++)
                {
                    if (tictactoeArray[iCountOuter, iCountInner] == ' ')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
