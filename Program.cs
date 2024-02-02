using TicTacToe;
using System;

internal class Program
{
    private static Supporting TTT = new Supporting();  // Make TTT static as it's used in a static context
    static void Main(string[] args)
    {
        bool gameOver = false;
        Console.WriteLine("Welcome to the TicTacToe Classic!");
        Console.WriteLine("Player 1 is always X, Player 2 is always O");
        Console.WriteLine("The game board is as follows");
        Console.WriteLine("0 1 2");
        Console.WriteLine("3 4 5");
        Console.WriteLine("6 7 8");

        string[] tictactoeArray = new string[9];
        for (int i = 0; i < tictactoeArray.Length; i++)
        {
            tictactoeArray[i] = " ";  // Initialize the game board with spaces
        }

        do
        {
            int playerChoice1 = GetPlayerChoice(1, tictactoeArray);  // Get choice for Player 1
            tictactoeArray[playerChoice1] = "X";

            TTT.PrinttictactoeArray(tictactoeArray);

            string result = TTT.CheckForWinner(tictactoeArray);
            if (result != null)
            {
                Console.WriteLine(result);
                gameOver = true;
                break;  // Exit the loop if the game is over
            }

            int playerChoice2 = GetPlayerChoice(2, tictactoeArray);  // Get choice for Player 2
            tictactoeArray[playerChoice2] = "O";

            TTT.PrinttictactoeArray(tictactoeArray);

            result = TTT.CheckForWinner(tictactoeArray);
            if (result != null)
            {
                Console.WriteLine(result);
                gameOver = true;
                break;  // Exit the loop if the game is over
            }

        } while (!gameOver);
    }

    private static int GetPlayerChoice(int playerNumber, string[] tictactoeArray)
    {
        int playerChoice;
        bool validChoice;
        do
        {
            Console.WriteLine($"Player {playerNumber}, please pick a number from 0 to 8 for an empty space");
            string input = Console.ReadLine();
            validChoice = int.TryParse(input, out playerChoice)
                          && playerChoice >= 0
                          && playerChoice <= 8
                          && tictactoeArray[playerChoice] == " ";  // Check if the cell is empty

            if (!validChoice)
            {
                Console.WriteLine("Invalid input or cell is not empty. Please input a number from 0 to 8 for an empty space.");
            }

        } while (!validChoice);
        return playerChoice;
    }
}
