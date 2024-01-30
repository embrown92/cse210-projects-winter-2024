using System;
using System.IO;
using static System.Console;
namespace Classes
{

    class Program
    {
         public static void Main(string[] args)
        {   
            //Display the welcome message.         
            WelcomeMessage();
           
            //Instantiate Menu class to get a choice and run journal choices.
            Menu choice = new Menu();
            choice.MenuAction();
                      
            //Display closing message.
            DismisalMessage();
        }

        //Method for welcome message.
        public static void WelcomeMessage()
        {
            
            Console.WriteLine("\nWelcome to your Journal!");
        }
        
        //Method for closing message.
        public static void DismisalMessage()
        {
            Console.WriteLine("\nThanks for taking the time to record your thoughts today!\n");
        }

        //Method for displaying menu and getting the user's choice, as well as verify the choice is proper.
        public string MenuChoices()
        {
            bool validChoice = false;

            do
            {
                Console.WriteLine("\nPlease select one of the following choices:");
                Console.WriteLine("\n1. Write a new entry");
                Console.WriteLine("2. Display previous entries");
                Console.WriteLine("3. Save");
                Console.WriteLine("4. Load an entry");
                Console.WriteLine("5. Clear File");
                Console.WriteLine("6. Quit");
                Console.Write("\nWhat would you like to do? ");

                _choice = Console.ReadLine();

                if (_choice == "1" || _choice == "2" || _choice == "3" || _choice == "4" || _choice == "5" || _choice == "6")
                {
                    validChoice = true;
                }
                else
                {
                    Console.WriteLine($"\n'{_choice}' not available choice. Please enter a valid choice.");
                }
            } while (!validChoice);

            return _choice;
        }


        //Method takes the user's choice and uses switch 
        // to call the right method from the user's choice.
        public void MenuAction()
        {
            string choice;
            List<Entry> _newEntries = new List<Entry>();
            Journal entry = new Journal();

            do
            {
                choice = MenuChoices();

                switch (choice)
                {
                    case "1":
                        //write journal entry
                        string _date = FindDate();
                        string _rPrompt = RetrievePrompt();
                        Console.WriteLine($"\nPrompt: {_rPrompt}");
                        Console.Write("\nAnswer: ");
                        string _userEntry = ReadLine().Trim();

                        //Set entry title
                        Console.Write("Enter a title for this entry: ");
                        string _userTitle = ReadLine().Trim();

                        //Instantiate entry and send off arguments to entry class
                        Entry newEntry = new Entry(_userTitle, _date, _rPrompt, _userEntry);

                        //Add newEntry to the _newEntries List.
                        _newEntries.Add(newEntry);
                        break;

                    case "2":
                        //display journal entry
                        entry._newEntries = _newEntries;
                        entry.JournalDetails();
                        break;

                    case "3":
                        // save to journal file
                        entry._newEntries = _newEntries;
                        entry._filename = entry.CreateFile();
                        entry.SaveToFile();
                        break;

                    case "4":
                        //load journal file
                        entry.ReadFromFile();
                        break;

                    case "5":
                        // clear file
                        entry.ClearFile();
                        break;

                    default:
                        break;
                }
            } while (choice != "6");
        }


        //Method gets the date and returns it to be used with entries
        public string FindDate()
        {
            DateTime currentTime = DateTime.Now;
            string dateText = currentTime.ToShortDateString();
            return dateText;
        }


        //Method for retrieving prompts from the Prompts class
        public string RetrievePrompt()
        {
            Prompts newPrompt = new Prompts();
            string _rprompt = newPrompt.FetchRandomPrompt();
            return _rprompt;
        }
    }
}