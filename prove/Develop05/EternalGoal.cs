public class Eternalgoal : Goal
{
    public Eternalgoal(string name, string description, int points) : base (name, description, points)
    {

    }

    public override void RecordEvent()
    {
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return  "EternalGoal" + "|" + GetShortName()  + "|" + GetDescription() + "|" + GetPoints();
    }
}