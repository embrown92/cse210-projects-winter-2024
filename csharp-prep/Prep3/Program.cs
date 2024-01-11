using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber = 13;

        int guessNumber = -1;

        while (guessNumber != magicNumber) 
        {
            Console.Write("Please enter a number between 1 and 20: ");
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