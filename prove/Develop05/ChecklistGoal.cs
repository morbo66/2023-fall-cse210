public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base (name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted) : base (name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted += 1;
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override int AddBonus()
    {
        if (_amountCompleted == _target)
        {
            return _bonus;
        }
        else
        {
            return 0;
        }
    }

    public override string GetDetailsString()
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
        detailsString += $"] {GetShortName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        return detailsString;
    }
    public override string GetStringRepresentation()
    {
        return  "ChecklistGoal" + "|" + GetShortName()  + "|" + GetDescription() + "|" + GetPoints() + "|" + _bonus + "|" + _target + "|" + _amountCompleted;
    }
}