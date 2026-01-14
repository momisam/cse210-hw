using System;

class Program
{
    static void Main(string[] args)
    {
        // Guess My Number Game

        // Create ONE random number generator (best practice)
        Random randomGenerator = new Random();

        string playAgain = "Yes";

        // Outer loop: controls replaying the game
        while (playAgain == "Yes")
        {
            // Generate a random secret number between 1 and 100
            int secretNumber = randomGenerator.Next(1, 101);

            int guessNumber = -1; // initialize guess so loop can start

            // Inner loop: keeps asking until the correct number is guessed
            while (guessNumber != secretNumber)
            {
                Console.Write("What is your guess?: ");
                string guess = Console.ReadLine();
                guessNumber = int.Parse(guess);

                if (guessNumber < secretNumber)
                {
                    Console.WriteLine("Higher!");
                }
                else if (guessNumber > secretNumber)
                {
                    Console.WriteLine("Lower!");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            // Ask user if they want to play again
            Console.Write("Would you like to play again (Yes/No)? ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}
