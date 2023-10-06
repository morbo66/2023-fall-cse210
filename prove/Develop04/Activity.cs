
public class Activity

{
    private string _activityName;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _activityName = name;
        _description = description;
    }
    
    public Activity ()
    {

    }

    public void SetDuration()
    {
        int userInput = 0;
        bool invalidInt = true;

        //Validate that the user is entering a whole positive number
        while (invalidInt)
        {
            Console.Write("\nHow long, in seconds, would you like for your session?");
            
            try
            {
            userInput = int.Parse(Console.ReadLine());
            if (userInput > 0)
            {
                invalidInt = false;
            }
            else
            {
                Console.WriteLine("\nInvlaid input, please enter a positive whole number. ");
            }
            }
            catch
            {
                Console.WriteLine("\nInvlaid input, please enter a positive whole number. ");
            }
        }
        _duration = userInput;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity.\n");
        Console.WriteLine(_description);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(5);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_activityName} Activity.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinnerSymbols = new List<string>();
        //    - \ | /
        spinnerSymbols.Add("-");
        spinnerSymbols.Add("\\");
        spinnerSymbols.Add("|");
        spinnerSymbols.Add("/");
        

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        while(DateTime.Now < endTime)
        {
            Console.Write(spinnerSymbols[i]);
            Thread.Sleep(500); 
            Console.Write("\b \b");
            
            i++;
            if (i == spinnerSymbols.Count())
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        Console.Write(seconds);
        for(int i = seconds - 1; i > 0; i--)
        {
            Thread.Sleep(1000);
            Console.Write($"\b \b{i}");
        }
        Thread.Sleep(1000);
    }
    public int GetDuration()
    {
        return _duration;
    }

}