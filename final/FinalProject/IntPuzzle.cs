public class IntPuzzle : Puzzle
{
    private int _answer;

    public IntPuzzle(int answer, string flavor, string puzzle, int failDamage, int successScore) : base (flavor, puzzle, failDamage, successScore)
    {
        _answer = answer;
    }

    public override void RunPuzzle(Creature creature)
    {
        
    }
}