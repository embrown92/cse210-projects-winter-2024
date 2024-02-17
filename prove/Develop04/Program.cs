using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity activity1 = new BreathingActivity("Breathing Activity", "Welcome to the Breathing Activity.", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", "Well done!");
        ReflectionActivity activity2 = new ReflectionActivity("Reflection Activity", "Welcome to the Reflection Activity.", "This activity will help you reflect on times in your life when you have shown strength and resilience and help you recognize the power you have and how you can use it in other aspects of your life.", "Good Job!");
        ListingActivity activity3 = new ListingActivity("Listing Activity", "Welcome to the Listing Activity.", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Nice!");

        bool doingActivity = true;
        while (doingActivity) {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity.");
            Console.WriteLine("  2. Start reflection activity.");
            Console.WriteLine("  3. Start listing activity.");
            Console.WriteLine("  4. Quit.");
            switch(Console.ReadLine()) {
                case "1":
                    activity1.DoActivity();
                    break;
                case "2":
                    activity2.DoActivity();
                    break;
                case "3":
                    activity3.DoActivity();
                    break;
                case "4":
                    doingActivity = false;
                    break;
            }
        }
    }
}