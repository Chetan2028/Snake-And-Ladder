using System;

namespace SnakeLadder
{
    class Program
    {
        public static int NO_PLAY = 0;
        public static int SNAKE = 1;
        public static int LADDER = 2;

        int position = 0;

        /// Creating an array which represents snake and ladder board.
        static int[] gameBoard = new int[101];

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
        /// This method plays the game
        /// </summary>
        public void GamePlay()
        {
            ///Iterates till the player is reached at 100 position
            while (position >= 0 && position <= 100)
            {
                int diceRoll = random.Next(1, 7);
                int options = random.Next(0, 3);

                if (options == LADDER)
                {
                    position += diceRoll;
                    if (position > 100)
                    {
                        position = position - diceRoll;
                    }
                }
                else if (options == SNAKE)
                {
                    position -= diceRoll;
                    if (position < 0)
                    {
                        position = 0;
                    }
                }
                else
                {
                    position += 0;
                }
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
            program.GamePlay();
        }
    }
}
