
public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }
    public int GetPoints()
    {
        return _points;
    }

    public string GetShortName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void AddPoints(int points)
    {
        _points += points;
    }
    public abstract void RecordEvent();
    
    public abstract bool IsComplete();

    public virtual int AddBonus()
    {
        return 0;
    }
    

    public virtual string GetDetailsString()
    {
        string detailsString = "[";
        if (IsComplete())
        {
            detailsString += "X";
        }
        else
        {
            detailsString += " ";
        }
        detailsString += $"] {_shortName} ({_description})";
        return detailsString;
    }

    public abstract string GetStringRepresentation();
   
}