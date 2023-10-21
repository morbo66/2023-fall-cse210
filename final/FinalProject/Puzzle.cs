using System.Dynamic;

public abstract class Puzzle
{
    private string _flavorText;
    private string _puzzleText;
    private int _failureDamage;
    private int _successScore;
    public Puzzle(string flavor, string puzzle, int failDamage, int successScore)
    {
        _flavorText = flavor;
        _puzzleText = puzzle;
        _failureDamage = failDamage;
        _successScore = successScore;
    }

    public string GetFlavor()
    {
        return _flavorText;
    }
    protected string GetPuzzle()
    {
        return _puzzleText;
    }
    protected int GetPoints()
    {
        return _successScore;
    }
    protected int GetFailDamage()
    {
        return _failureDamage;
    }
    public abstract void RunPuzzle(Creature creature);
}