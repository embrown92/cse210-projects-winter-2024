using System;

public class ListingActivity : Activity
{
    // Varible
    private string[] _prompts = {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};

    // Constructor
    public ListingActivity(string _activityName, string _startingMessage, string _activityDescription, string _endingMessage) : base(_activityName, _startingMessage, _activityDescription, _endingMessage) 
    {

    }

    // Do activity method
    public void DoActivity() 
    {
        StartActivity();
        Console.Write($" ---{RandomPrompt()}---");
        Console.Write("You may begin in: ");
        CountdownTimer(3);
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(5);
        while (DateTime.Now < endTime) {
            Console.Write("> ");
            Console.ReadLine();
        }
        EndActivity();
    }

    // Random prompt method
    private string RandomPrompt() 
    {
        Random rnd = new Random();
        int randomIndex = rnd.Next(0, _prompts.Length);
        return _prompts[randomIndex];
    }
    
}
