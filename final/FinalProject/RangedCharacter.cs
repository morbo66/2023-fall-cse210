public class RangedCharacter : Creature
{
    public RangedCharacter(string name) : base (name)
    {
        _armor = 8;
        _attackValue = 12;
        _hitPoints = 40;
    }
    
   

    public override int GetDamage()
    {
        return 8 + (_score/10);
    }

    public override bool IsRanged()
    {
        return true; 
    }
}