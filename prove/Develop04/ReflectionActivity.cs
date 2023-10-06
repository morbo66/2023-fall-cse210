public class ReflectionActivity : Activity
{
    private List<string> _promptsList = new List<string>();

    private List<string> _questionsList = new List<string>();
    
    public ReflectionActivity(string name, string description) : base(name, description)
    {

    }
    private string GetRandomPrompt()
    {
        _promptsList.Add("Think of a time when you stood up for someone else.");
        _promptsList.Add("Think of a time when you did something really difficult.");
        _promptsList.Add("Think of a time when you helped someone in need.");
        _promptsList.Add("Think of a time when you did something truly selfless.");

        Random random = new Random();
        int index = random.Next(_promptsList.Count);

        return _promptsList[index];
    }

    private string GetRandomQuestion()
    {
        _questionsList.Add("Why was this experience meaningful to you?");
        _questionsList.Add("Have you ever done anything like this before?");
        _questionsList.Add("How did you get started?");
        _questionsList.Add("How did you feel when it was complete?");
        _questionsList.Add("What made this time different than other times when you were not as successful?");
        _questionsList.Add("What is your favorite thing about this experience?");
        _questionsList.Add("What could you learn from this experience that applies to other situations?");
        _questionsList.Add("What did you learn about yourself through this experience?");
        _questionsList.Add("How can you keep this experience in mind in the future?");

        Random random = new Random();
        int index = random.Next(_questionsList.Count);

        return _questionsList[index];
    }    

    private void DisplayPrompt()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(3);
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n~~~ {GetRandomPrompt()} ~~~");
        Console.WriteLine("\nWhen you have something in mind press enter to continue");
        Console.ReadLine();
        Console.WriteLine("\nNow Ponder on each of the following quesions as they relate to this experience.");
        Console.Write("You may begin in. ");
        ShowCountDown(5);

    }
    private void DisplayQuestions(int pauseLength)
    {
        Console.Write($"\n> {GetRandomQuestion()}");
        ShowSpinner(pauseLength);
    }

    public void Run()
    {
        DisplayStartingMessage();
        SetDuration();
        DisplayPrompt();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        Console.Clear();
        while (DateTime.Now < endTime)
        {
            DisplayQuestions(7);
        }
        DisplayEndingMessage();
       

    }

}