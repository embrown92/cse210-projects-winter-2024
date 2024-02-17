using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a base "Assignment" object
        Assignment a1 = new Assignment("Pandora Williams", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        // create derived class assignments
        MathAssignment a2 = new MathAssignment("Casey Jones", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeWorkList());

        WritingAssignment a3 = new WritingAssignment("Peter Pipper", "European History", "The Causes of World Ward II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}