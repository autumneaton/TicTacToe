
using TicTacToe;

internal class Program
{
    Supporting TTT = new Supporting();
    private void Main(string[] args)
    {
        bool gameOver = false;
        Console.WriteLine("Welcome to the TicTacToe Classic!");
        Console.WriteLine("Player 1 is always X, Player 2 is always O");
        Console.WriteLine("The game board is as follows");
        Console.WriteLine("0 1 2");
        Console.WriteLine("3 4 5");
        Console.WriteLine("6 7 8");

        string[] tictactoeArray = new string[9];

        Console.WriteLine("Player 1, please pick a number from 0 to 8");
        string player1 = Console.ReadLine();

        do
        {
            bool stringCheck = true;
            do
            {
                if (player1.Length > 1)
                {
                    Console.WriteLine("Please input a number from 0 to 8");
                    stringCheck = false;
                }
                if (Int32.Parse(player1) < 0 || Int32.Parse(player1) > 8)
                {
                    Console.WriteLine("Please input a number from 0 to 8");
                    stringCheck = false;
                }
                else
                {
                    stringCheck = true;
                }

            } while (!stringCheck);

            Console.WriteLine("Player 2, please pick a number from 0 to 8");
            string player2 = Console.ReadLine();


            do
            {
                if (player2.Length > 1)
                {
                    Console.WriteLine("Please input a number from 0 to 8");
                    stringCheck = false;
                }
                if (Int32.Parse(player2) < 0 || Int32.Parse(player2) > 8)
                {
                    Console.WriteLine("Please input a number from 0 to 8");
                    stringCheck = false;
                }
                else
                {
                    stringCheck = true;
                }

            } while (!stringCheck);

            for (int i = 0; i < tictactoeArray.Length; i++)
            {   
                if (i == Int32.Parse(player1))
                {
                    tictactoeArray[i] = "X";
                }
                if (i == Int32.Parse(player2))
                {
                    tictactoeArray[i] = "O";
                }
            }

            TTT.PrinttictactoeArray(tictactoeArray);
            TTT.CheckForWinner(tictactoeArray);

        } while (gameOver = false);
    }
}