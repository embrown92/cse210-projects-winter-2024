using System;
using System.IO;
using System.Collections.Generic;
using static System.Console;
using System.Text;

namespace Foundation3
{
    /*For creativity I added color, I formatted the detail sections such that they are labeled and easy to distinguish and view.
    Also, I made it so that each event had a time frame instead of just a starting time. 
    */
    class Program
    {
        static void Main(string[] args)
        {
            //List to track all the events
            List<Event> _events = new List<Event>();


            //Intro to the program
            Console.WriteLine("\nEvent Planning Program!\n");


            //Pause to allow user to see information
            Console.WriteLine("Press any key to see details by event type...");
            Console.ReadKey();


            //Events instances to add info to the program
            Address address1 = new Address("372 Sisco Rd", "Pomona Park", "FL", 32181);
            Reception reception = new Reception("Wilson-Clark Wedding", "Wedding Reception for Lacey Brown and Ben Stevens", new DateTime (2023, 12, 04, 19, 0, 0), new TimeSpan(2, 30, 0), address1, "eventrsvp@events.com");        
            _events.Add(reception);
            Address address2 = new Address("5678 Bountiful Place", "St. George", "UT", 84502);
            Lecture lecture = new Lecture("How to Master the Art of Continuous Improvement", "Lecture on becoming 1% each day", new DateTime (2023, 8, 30, 17, 30, 0), new TimeSpan(1, 0, 0), address2, "James Clear",50);
            _events.Add(lecture);
            Address address3 = new Address("2479 Jump Street", "Boise", "ID", 83701);
            OutdoorGathering gathering = new OutdoorGathering("Summer Extravaganza", "Celebrate the beginning of Summer with a Party", new DateTime (2024, 6, 1, 10, 0, 0), new TimeSpan (3, 00, 0), address3, "Sunny with a gentle breeze");
            _events.Add(gathering);

            
            //Iterate through the list to display different length media messages
            foreach (Event e in _events)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine($"{e.GetType().Name}");
                Console.WriteLine("\nStandard Description:\n");
                Console.WriteLine(e.StandardDetails());
                Console.WriteLine("\n\nFull Description:\n");
                Console.WriteLine(e.FullDetails());
                Console.WriteLine("\n\nShort Description:\n");
                Console.WriteLine(e.ShortDescription());

                //Pause between each type of event
                Console.WriteLine("\nPress any key to see next event...");
                Console.ReadKey();
            }
        }
    }
}