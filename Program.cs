using System;

namespace SnakeLadder
{
    class Program
    {
        int position = 0;


        /// Creating an array which represents snake and ladder board.
        static int[] gameBoard = new int[10];

        /// Creates a reference of Random Class
        Random random = new Random();

        /// <summary>
        /// Initalizes the board.
        /// </summary>
        public void InitalizeBoard()
        {
            for (int index = 0; index < gameBoard.Length; index++)
            {
                gameBoard[index] = index;
            }
        }

        /// <summary>
        /// Rolls the dice.
        /// </summary>
        public void RollDice()
        {
            int diceRoll = random.Next(1, 7);
        }
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Program program = new Program();
            program.InitalizeBoard();
            program.RollDice();
        }
    }
}
