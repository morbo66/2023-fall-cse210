public class StringPuzzle : Puzzle
{
    private string _answer;

    public StringPuzzle(string answer, string flavor, string puzzle, int failDamage, int successScore) : base (flavor, puzzle, failDamage, successScore)
    {
        _answer = answer;
    }

    public override void RunPuzzle(Creature creature)
    {
        string playerGuess = GetStringFromUser(GetPuzzle());
        if (playerGuess.Equals(_answer))
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

    private string GetStringFromUser(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }
}