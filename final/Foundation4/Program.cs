using System;

public class Program
{
    static void Main(string[] args)
    {
        // Intro Message
        Console.WriteLine("\nWelcome to the Exercise Tracking App!");
        Console.WriteLine("Press any key to get started...");
        Console.ReadKey();

        // List to track activity
        List<Activity> _activities = new List<Activity>();

        // Exercise activity instances for each category
        Swimming swimming = new Swimming(new DateTime(2023, 06, 30), 35, 50);
        _activities.Add(swimming);
        Running running = new Running(new DateTime(2023, 7, 5), 30, 3);
        _activities.Add(running);
        Cycling cycle = new Cycling(new DateTime(2023, 7, 12), 65, 9.5);
        _activities.Add(cycle);

        //Iterate through activity list and display the summary info
        foreach (Activity a in _activities)
        {
            Console.WriteLine("");
            Console.WriteLine(a.GetSummary());
            Console.WriteLine("");

            //Pause that allows user to look at each set of info
            Console.WriteLine("Press any key to see next tracking info...");
            Console.ReadKey();
        }
    }
}