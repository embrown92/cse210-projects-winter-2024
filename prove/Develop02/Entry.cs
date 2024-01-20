using System;
using static System.Console;

namespace Classes
{
    class Entry
    {
        // Class variables to hold the different parts of the entry
        // Reminder: The C# convention is to start member variables with an underscrore(_)
        public string _prompt;
        public string _entry;
        public string _date;
        public string _title;


        //Constructor for the Entry class that receives arguments and assigns values to the class variables.
        public Entry(string ent_title, string ent_date, string ent_prompt, string ent_entry)
        {
            _title = ent_title;
            _date = ent_date;
            _prompt = ent_prompt;
            _entry = ent_entry;
        }

        // Method for displaying the entry details in a specific format.
        public void ShowEntryDetails()
        {
            Console.WriteLine($"\n Title: {_title} ");
            Console.WriteLine($"Date: {_date} ");
            Console.WriteLine($"Prompt: {_prompt} ");
            Console.WriteLine($"{_entry} ");
        }

        // Method to create the string for writing the data to a file 
        // that can be seperated later.
        public string CreateSavedData()
        {
            string entryData = ($"{_title}~~{_date}~~{_prompt}~~{_entry}\n");
            return entryData;
        }

    }
}
