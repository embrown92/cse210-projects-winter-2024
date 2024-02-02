using System;

public class Program
{
    static void Main(string[] args)
    {

        string text = "Trust in the LORD with all your heart, and do not lean on your own understanding. In all your ways acknowledge Him, and He will make straight your paths.";
        string book = "Proverbs";
        int chapter = 3;
        int verse = 5;
        int endVerse = 6;

        int wordsToHide = 0;

        // Instantiate reference
        Reference reference = new Reference(book, chapter, verse, endVerse);

        // Instantiate scripture
        Scripture scripture = new Scripture(reference, text);

        // Ask for difficulty
        while (wordsToHide == 0)
        {
			Console.WriteLine();
            Console.WriteLine("Welcome to the Scripture Memorizer!");
			Console.WriteLine();
            Console.WriteLine("Please select difficulty: ");
            Console.WriteLine("1: Easy");
			Console.WriteLine("2: Medium");
			Console.WriteLine("3: Hard");
			Console.WriteLine();
			Console.Write("Your selection (1, 2, 3): ");
			string input = Console.ReadLine();
			if (input == "1")
				wordsToHide = 3;
			if (input == "2")
				wordsToHide = 6;
			if (input == "3")
				wordsToHide = 10;
			Console.Clear();
        }
        
        Console.Clear();

        // Main loop
        while (!scripture.IsCompletelyHidden())
        {

            // Print scripture
            Console.WriteLine(reference.GetDisplayText() + " " + scripture.GetDisplayText());

            // Check for "quit" input
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                return;
            }

            // Clear console screen
            Console.Clear();

            // Hide random words from the scripture verse
            scripture.HideRandomWords(wordsToHide);
        }
    }
}