using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage. ");
        string studentInput = Console.ReadLine();
        int gradePercentage = int.Parse(studentInput);

        string letter = "";

        if (gradePercentage >  90)
        {
            letter = "A";
        }
        else if (gradePercentage > 80)
        {
            letter = "B";
        }
        else if (gradePercentage > 70)
        {
            letter = "C";
        }
        else if (gradePercentage > 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (gradePercentage > 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you failed. Please try again next time.");
        }
    }
}