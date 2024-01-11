using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        int userNumber = -1;

        // Ask user for a list of numbers
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Find the sum
        int sum = 0;

        foreach (int number in numbers)
        {
         sum += number;   
        }

        Console.WriteLine($"The sum is: {sum}");

        // Find the average
        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The average is: {average}");

        // Find the max number
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}