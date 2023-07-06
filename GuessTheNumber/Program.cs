using System;

class Program 
{

    static void Main(string[] args)
    {
        // Welcome Message
        // Blank WriteLines give space on the print.
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Welcome to 'Guess The Number' the Game");

        // Set the secret number
        Random random = new Random();

        int secretNumber = random.Next(1, 101); // Return random number, between 1 and 100.

        // Inform the player about what is happening.
        Console.WriteLine("I'm thinking of a number between 1 and 100.");

        // Game Logic
        for (int i = 0; i < 5; i++)
        {
            //interact with the player.
            Console.Write("Enter your guess: ");
            String input = Console.ReadLine();
            int guess = int.Parse(input); // Converts from String into Int number.

            // This code will be executed only if the FOR condition is met.
             if (guess < secretNumber)
            {
                Console.WriteLine("Too Low! "); 
            }

            else if (guess > secretNumber)
            {
                Console.WriteLine("Too High! "); 
             }
            else
            {
                Console.WriteLine("You've won! "); 
                return; // Ends the game
            }
        }
        Console.WriteLine("Game Over! ");

    }

}


