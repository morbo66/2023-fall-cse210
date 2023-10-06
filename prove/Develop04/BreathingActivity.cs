using System.Diagnostics;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }
    public BreathingActivity()
    {

    }
    public void Run()
    {
        DisplayStartingMessage();
        SetDuration();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine("");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        int breathIn = 5;
        int breathOut = 5;
        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreath in.");
            for (int i = 1; i <= breathIn; i++)
            {
                Console.Write($"\b.{i}");
                Thread.Sleep(1100);
            }

            Console.Write("\nNow, breath out");
            for(int i = breathOut; i > 0; i--)
            {
                Console.Write(".");
            }
            Console.Write(breathOut);
            for(int i = breathOut - 1; i > 0; i--)
            {
                Thread.Sleep(1100);
                Console.Write($"\b \b\b{i}");
            }
            Thread.Sleep(1100);
            Console.WriteLine();
                     
        }
        DisplayEndingMessage();
    }
}