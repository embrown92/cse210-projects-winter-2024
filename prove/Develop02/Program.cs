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
            DisplayWelcomeMessage();
           
            //Instantiate Menu class to get a choice and run journal choices.
            Menu choice = new Menu();
            choice.MenuAction();
                      
            //Display closing message.
            DisplayDismisalMessage();
        }

        
        //Method for welcome message.
        public static void DisplayWelcomeMessage()
        {
            
            Console.WriteLine("\nWelcome to the Journal Program!");
        }

        
        //Method for closing message.
        public static void DisplayDismisalMessage()
        {
            Console.WriteLine("\nThanks for recording your thoughts!\n");
        }
    }
}