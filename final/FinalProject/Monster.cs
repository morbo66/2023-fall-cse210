public class Monster : Creature
{
    
    private int _numOfMonsters;
    private int _scoreOnDefeat;
    private int _damage;
    private string _introFlavorText;
    private string _defeatFlavor;

    public Monster(int attack, int armor, int num, int score, int hp, int damage, string intro, string defeat, string name) : base (name)
    {
        _attackValue = attack;
        _armor = armor;
        _numOfMonsters = num;
        _scoreOnDefeat = score;
        _hitPoints = hp;
        _introFlavorText = intro;
        _defeatFlavor = defeat;
        _damage = damage;
    }
    public override int GetDamage()
    {
        return _damage;
    }
    public int GetNumOfMonsters()
    {
        return _numOfMonsters;
    }
    public int GetDefeatScore()
    {
        return _scoreOnDefeat;
    }
    public string GetIntro()
    {
        return _introFlavorText;
    }
    public string GetDefeatFlavor()
    {
        return _defeatFlavor;
    }


}