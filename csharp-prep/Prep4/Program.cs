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

        // Find the smallest positive number
        int smallestPosNum = 999999;

         foreach (int number in numbers)
        {
            if (number > 0 &&  number < smallestPosNum)
            {
                smallestPosNum = number;
            }
        }

        Console.WriteLine($"The smallest positive number is: {smallestPosNum}");

        //Sorted list
        Console.WriteLine("Here is the sorted list: ");

        numbers.Sort();
        for (int i = 0; i < numbers.Count; i++)
        {
            int numbersSorted = numbers[i];
            Console.WriteLine(numbersSorted);
        }

    }
}