public abstract class Creature
{
    private string _characterName;
    protected int _hitPoints;
    protected int _score;
    protected int _armor;
    protected int _attackValue;
    public Creature(string name)
    {
        _characterName = name;
        _score = 0;
    }

     public int GetAttack()
    {
        return _attackValue;
    }
    public abstract int GetDamage();
    public virtual bool IsRanged()
    {
        return false;
    }
    public  void TakeDamgage(int damage)
    {
        _hitPoints -= damage;
    }
    public void GainScore(int gain)
    {
        _score += gain;
    }
    public string GetCharacterInfo()
    {
        return _characterName + " " + _hitPoints + " " + _score;
    }
    public bool IsAlive()
    {
        if (_hitPoints > 0)
        {
            return true;
        }
        else
        {
            return false; 
        }
    }
    public  void TakeAttack(int attack, int damage)
    {
        if (attack >= _armor)
        {
            _hitPoints -= damage;
        }
        
    }
}