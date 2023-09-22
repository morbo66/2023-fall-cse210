public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    
    public string GetRandomPrompt()
    {

        
       _prompts.Add("What was my favorite conversation today?");
       _prompts.Add("What inspired gratitude in me today?");
       _prompts.Add("Who did or could I have shown charity to today?");
       _prompts.Add("Who made an impression on me today? Why?");
       _prompts.Add("Who could I have been kinder to today?");
       _prompts.Add("What was the strongest emotion I felt today?");
       _prompts.Add("If I had one thing I could do over today, what would it be?");
        
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }


}