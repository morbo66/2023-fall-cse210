public class MeleeCharacter : Creature
{
    
    public MeleeCharacter(string name) : base (name)
    {
        _armor = 10;
        _attackValue = 10;
        _hitPoints = 25;
    }
    
   

    public override int GetDamage()
    {
        return 10 + (_score/10);
    }

}