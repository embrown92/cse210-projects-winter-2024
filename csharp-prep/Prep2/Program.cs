using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage. ");
        string studentInput = Console.ReadLine();
        int gradePercentage = int.Parse(studentInput);

        if (gradePercentage >  90)
        {
            Console.WriteLine("You got an A!");
        }
        else if (gradePercentage > 80)
        {
            Console.WriteLine("You got a B!");
        }
        else if (gradePercentage > 70)
        {
            Console.WriteLine("You got a C.");
        }
        else if (gradePercentage > 60)
        {
            Console.WriteLine("You got a D.");
        }
        else
        {
            Console.WriteLine("You got an F.");
        }

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