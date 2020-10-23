using System;

namespace SnakeLadder
{
    class Program
    {
        /// Constants
        public const int NO_PLAY = 0;
        public const int SNAKE = 1;
        public const int LADDER = 2;
        public const int WON = 100;

        int position1 = 0;
        int position2 = 0;
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
        /// <returns></returns>
        public void GamePlay()
        {
            int diceCount = 0;

            ///Iterates till the player is reached at 100 position
            while (position1 >= 0 && position1 <= 100 && position2 >= 0 && position2 <= 100)
            {
                ///Generates the random number for dice roll
                int diceRoll1 = random.Next(1, 7);
                int diceRoll2 = random.Next(1, 7);
                ///Generate the random number for options
                int options = random.Next(0, 3);

                ///Checks the condition of option and assigns the position
                if (options == LADDER)
                {
                    position1 += diceRoll1;
                    position2 += diceRoll2;
                    ///Checks for the position
                    ///If the position is greater than 100 then negate the dice roll
                    if (position1 > 100)
                    {
                        position1 = position1 - diceRoll1;
                    }
                    if (position2 > 100)
                    {
                        position2 = position2 - diceRoll2;
                    }
                }
                else if (options == SNAKE)
                {
                    position1 -= diceRoll1;
                    position2 -= diceRoll2;
                    ///Checks for the position
                    ///If the position is negative then assiginig position as zero
                    if (position1 < 0)
                    {
                        position1 = 0;
                    }
                    if (position2 < 0)
                    {
                        position2 = 0;
                    }
                }
                else
                {
                    ///When there is no play then player is at same position
                    position1 += 0;
                    position2 += 0;
                }
                diceCount++;

                Console.WriteLine("Dice Count for Player1  and Player2 : " + diceCount);
                Console.WriteLine("The position of Player1  : " + position1);
                Console.WriteLine("The position of Player2  : " + position2);

                ///Checking for position if it is 100 then break the loop
                if (position1 == WON)
                {
                    Console.WriteLine("Player1 won the Game!!");
                    break;
                }
                if (position2 == WON)
                {
                    Console.WriteLine("Player2 won the Game!!");
                    break;
                }
            }
            Console.WriteLine("Total dice count of Player1 and Player2 is : " + diceCount);
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
