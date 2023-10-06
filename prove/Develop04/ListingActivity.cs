public class listingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public listingActivity(string name, string description) : base(name, description)
    {

    }
    
    private void DisplayRandomPrompt()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        Random random = new Random();
        int index = random.Next(_prompts.Count);

        Console.WriteLine($"~~~ {_prompts[index]} ~~~");
    }
    private void GetListFromUser()
    {
        Console.Write(">");
        Console.ReadLine();
    }

    public void Run()
    {
        DisplayStartingMessage();
        SetDuration();

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine("");

        Console.WriteLine("List as many responses you can to the following prompt");
        DisplayRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        
       
        while (DateTime.Now < endTime)
        {
            GetListFromUser();
            _count ++;
        }

        Console.WriteLine($"You listed {_count} item(s)!");
        DisplayEndingMessage();

    }

}