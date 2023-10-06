using System;
using System.Data;


class Program
{
    static void Main(string[] args)
    {
        //EXCEEDING EXPECTATIONS: 
        //Input validation throughout, Result table at the end of the program showing the user the total time spent on mindfulness.
        //Please note: I didn't use the Activity.ShowCountDown() method in the breathing activity because I felt that activity could use 
        //a differrent countdown than the other 2.
        
        int breathingTotal = 0;
        int reflectionTotal = 0;
        int listingTotal = 0;

        string userChoice = "0";
        while(userChoice != "4")
        {
            //display menu
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine("Select a choice from the menu:");
            Console.Write(">");
            userChoice = Console.ReadLine();

            if(userChoice == "1")
            {
                BreathingActivity breathing = new BreathingActivity("Breathing", "This activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing");
                
                breathing.Run();
                breathingTotal += breathing.GetDuration();
            }
            else if( userChoice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity("Reflection","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
              
                reflection.Run();
                reflectionTotal += reflection.GetDuration();
            }
            else if( userChoice == "3")
            {
                listingActivity listing = new listingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as y ou can in a certain area");

                listing.Run();
                listingTotal += listing.GetDuration();

            }
            else if(userChoice != "4")
            {
                Console.WriteLine("\nInvalid selection please enter 1-4\n");
                Thread.Sleep(1000);
            }
        }
        Console.WriteLine("\nYour results:");
        Console.WriteLine($"Breathing Activity: {breathingTotal} Seconds");
        Console.WriteLine($"Reflection Activity: {reflectionTotal} Seconds");
        Console.WriteLine($"Listing Activity: {listingTotal} Seconds");
        Console.WriteLine($"For a total of {listingTotal + reflectionTotal + breathingTotal} seconds of mindfulness today!\n");
    

    }
}