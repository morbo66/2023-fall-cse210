public class IntPuzzle : Puzzle
{
    private int _answer;

    public IntPuzzle(int answer, string flavor, string puzzle, int failDamage, int successScore) : base (flavor, puzzle, failDamage, successScore)
    {
        _answer = answer;
    }

    public override void RunPuzzle(Creature creature)
    {
        
        int playerGuess = GetIntFromUser(GetPuzzle(), 0, 99999999);
        if (playerGuess == _answer)
        {
            Console.WriteLine($"A hidden door clicks open you gain {GetPoints} points.");
            creature.GainScore(GetPoints());
        }
        else
        {
            creature.TakeDamgage(GetFailDamage());
            if (creature.IsAlive())
            {
                Console.WriteLine($"A hidden door clicks open as the room catches fire you scramble out taking {GetFailDamage()} points of damage.");
            }
            else
            {
                Console.WriteLine("The last thing you see is fire surrounding you");
            }

        }
    }

     private int GetIntFromUser(String prompt, int min, int max)
    {
        Console.WriteLine(prompt);
        Console.Write(">");
        int userInput = -1;
        string retry = $"Invalid input: Please enter a number between {min} and {max}.\n>";
        while(true)
        {
            try
            {
                userInput = int.Parse(Console.ReadLine());
                if(userInput >= min && userInput <= max)
                {
                    break;
                }
                else
                {
                    Console.Write(retry);    
                }
            }
            catch
            {
                Console.Write(retry);
            }
            
        }
        return userInput;
    }
}