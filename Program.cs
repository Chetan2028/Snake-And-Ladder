using System;

namespace SnakeLadder
{
    class Program
    {
        int position = 0;

        /// <summary>
        /// Creating an array which represents snake and ladder board.
        /// </summary>
        static int[] gameBoard = new int[101];

        /// <summary>
        /// Initalizes the board.
        /// </summary>
        public void initalizeBoard()
        {
            for (int index = 0; index < gameBoard.Length; index++)
            {
                gameBoard[index] = index;
            }
        }
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Program program = new Program();
            program.initalizeBoard();
        }
    }
}
