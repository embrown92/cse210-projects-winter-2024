using System;

public class Activity
{
    // Protected variables for the Activity class
    protected string _activityName;
    protected string _startingMessage;
    protected string _activityDescription;
    protected string _endingMessage;
    protected int _duration;

    // Constructor that takes in four parameters
    public Activity(string activityName, string startingMessage, string activityDescription, string endingMessage)
    {
        _activityName = activityName;
        _startingMessage = startingMessage;
        _activityDescription = activityDescription;
        _endingMessage = endingMessage;
    }

    // Start Activity method
    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine(_startingMessage);
        Console.WriteLine();
        Console.WriteLine(_activityDescription);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like your session to go? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Be ready to get started...");
        Pause(3);
    }

    // End Activity method
    public void EndActivity()
    {
        Console.WriteLine(_endingMessage);
        Pause(2);
        Console.WriteLine($"You have completed {_duration} seconds of the {_activityName}.");
        Pause(3);
    }

    // Pause method
    public void Pause(float pauseDuration)
    {
        string[] framesArray = {"|", "/", "-", "\\"};
        float pauseTime = 0;
        while (pauseTime < pauseDuration) 
        {
            for (int i = 0; i < framesArray.Length; i ++)
            {
                Console.Write($"{framesArray[i % 4]}");
                Thread.Sleep(250);
                pauseTime += 0.25F;
                Console.Write("\b");
            }
        }
        Console.WriteLine(" ");
    }

    // Coundown timer method
    protected void CountdownTimer(int seconds)
    {
        for (int t = seconds; t > 0; t --)
        {
            int secondsCharacterLength = t.ToString().Length;
            Console.WriteLine($"{t} ");
            Thread.Sleep(1000);
            for (int i = 0; i < secondsCharacterLength + 1; i ++)
            {
                Console.WriteLine("\b");
            }
        }
        Console.WriteLine(" ");
    }
}