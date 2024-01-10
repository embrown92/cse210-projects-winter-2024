using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their grade percentage
        Console.Write("Please enter your grade percentage. ");
        string studentInput = Console.ReadLine();
        int gradePercentage = int.Parse(studentInput);

        string letter = "";

        // series of if-elif-else statements to print out the appropriate letter grade
        if (gradePercentage >=  90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }



        // Add to your code the ability to include a "+" or "-" next to the letter grade
        int determineSign = gradePercentage % 10;
        string sign = "";

        if (determineSign >= 7)
        {
            sign = "+";
        }
        else if (determineSign >= 3)
        {
            sign = " ";
        }
        else if (determineSign < 3)
        {
            sign = "-";
        }

        string convertedGrade = letter + sign;
        string grade = "";

        if (convertedGrade == "A+")
        {
            grade = "A";
        }
        else if (convertedGrade == "F-")
        {
            grade = "F";
        }
        else if (convertedGrade == "F+")
        {
            grade = "F";
        }
        else
        {
            grade = convertedGrade;
        }


        // statement to determine if the user passed the course or not
        Console.WriteLine($"Your grade is: {grade}");

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