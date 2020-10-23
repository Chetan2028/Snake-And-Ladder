using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace SnakeLadder
{
    class Program
    {
        public static int NO_PLAY = 0;
        public static int SNAKE = 1;
        public static int LADDER = 2;

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
        public int RollDice()
        {
            int diceRoll = random.Next(1, 7);
            return diceRoll;
        }

        /// <summary>
        /// Check for the options
        /// </summary>
        public void OptionCheck()
        {
            ///Checking for 3 options
            int options = random.Next(0, 3);

            ///Checks for the conditon and assigns the positons
            if (options == NO_PLAY)
            {
                position += 0;
            }
            else if (options == LADDER)
            {
                position += RollDice();
            }
            else
            {
                position -= RollDice();
            }
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
            program.OptionCheck();
        }
    }
}
