using System;

public class ReflectionActivity : Activity
{
    // Variables
    private string[] _prompts = {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    private string[] _questions = {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};

    // Constructor
    public ReflectionActivity(string _activityName, string _startingMessage, string _activityDescription, string _endingMessage) : base(_activityName, _startingMessage, _activityDescription, _endingMessage)
    {

    }

    // Do activity method
    public void DoActivity() 
    {
        StartActivity();
        int numberOfQuestions = _duration/10;
        int timePerQuestion = _duration/numberOfQuestions;
        string prompt = RandomPrompt();
        string[] questions = RandomQuestions(numberOfQuestions);
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine($"Now ponder on each of the following {numberOfQuestions} questions as they relate to this experience.");
        Console.Clear();
        for (int i = 0; i < numberOfQuestions; i ++) {
            Console.Write($"{questions[i]} ");
            CountdownTimer(timePerQuestion);
            Console.WriteLine();
        }
        EndActivity();
    }

    // Random Prompt method
    private string RandomPrompt() 
    {
        Random rnd = new Random();
        int randomIndex = rnd.Next(0, _prompts.Length);
        return _prompts[randomIndex];
    }

    // Random questions method
    private string[] RandomQuestions(int numberOfQuestions) 
    {
        string[] randomQuestions = new string[numberOfQuestions];
        int[] usedIndexNumbers = new int[numberOfQuestions];
        for (int i = 0; i < numberOfQuestions; i ++) {
            bool choosing = true;
            while (choosing) {
                Random rnd = new Random();
                int randomIndex = rnd.Next(0, _questions.Length);
                if (Array.IndexOf(usedIndexNumbers, randomIndex) == -1) {
                    usedIndexNumbers[i] = randomIndex;
                    randomQuestions[i] = _questions[i];
                    choosing = false;
                }
            }
        }
        return randomQuestions;
    }
    
}
