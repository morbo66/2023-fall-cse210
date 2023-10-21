public class StringPuzzle : Puzzle
{
    string _answer;

    public StringPuzzle(string answer, string flavor, string puzzle, int failDamage, int successScore) : base (flavor, puzzle, failDamage, successScore)
    {
        _answer = answer;
    }

    public override void RunPuzzle(Creature creature)
    {
        
    }
}