using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Guess a number between 1 and 20.");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 21);

        int guessNumber = -1;

        while (guessNumber != magicNumber) 
        {
            Console.Write("Please enter your guess: ");
            string userInput = Console.ReadLine();
            guessNumber = int.Parse(userInput);

            if (guessNumber < magicNumber)
            {
                Console.WriteLine("Try to guess higher.");
            }
            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("Try to guess lower.");
            }
            else 
            {
                Console.WriteLine("You guessed the number!");
            }
        }
    }
}