using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your percentage? ");
        int percent = int.Parse(Console.ReadLine());

        string letter = "";

        if (percent < 60 )
        {
            letter = "F";
        }        
        else if (percent < 70 )
        {
            letter = "D";
        }
        else if (percent < 80 )
        {
            letter = "C";
        }
        else if (percent < 90 )
        {
            letter = "B";
        }
        else
        {
            letter = "A";
        }

        Console.Write($"You recieved a(n) {letter}, ");
        if (percent >= 70)
        {
            Console.Write("congratualtions you passed!");
        }
        else
        {
            Console.Write("better luck next time.");
        }
    }
}