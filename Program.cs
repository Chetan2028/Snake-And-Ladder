using System;

namespace SnakeLadder
{
    class Program
    {
        /// Constants
        public const int NO_PLAY = 0;
        public const int SNAKE = 1;
        public const int LADDER = 2;

        int position = 0;

        /// Creating an array which represents snake and ladder board.
         int[] gameBoard = new int[101];

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
            int diceCount = 0;
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
                diceCount++;
                Console.WriteLine("Dice Count : " + diceCount);
                Console.WriteLine("The position is : " + position);

                ///Checking for position if it is 100 then break the loop
                if (position == 100)
                {
                    Console.WriteLine("You Won the Game!!!!!!");
                    break;
                }
            }
            Console.WriteLine("Total dice count are : " + diceCount);
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
