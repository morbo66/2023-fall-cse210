public class Creature
{
    private string _characterName;
    protected int _hitPoints;
    protected int _score;
    protected int _armor;
    protected int _attackValue;
    public Creature()
    {

    }
    public Creature(string name)
    {
        _characterName = name;
        _score = 0;
    }

     public int GetAttack()
    {
        return _attackValue;
    }
    public virtual int GetDamage()
    {
        return 0;
    }
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
        return "Name: " + _characterName + " Hp: " + _hitPoints + " Score:" + _score;
    }
    public int GetScore()
    {
        return _score;
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
    public void SetHP(int hp)
    {
        _hitPoints = hp;
    }
    public int GetHP()
    {
        return _hitPoints;
    }
}