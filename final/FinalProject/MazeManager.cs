public class MazeManager
{
    private List<Monster> _monsters;
    private List<Puzzle> _puzzles;
    private Creature _playerCharacter;
    private int _victoryGoal;
    public MazeManager(List<Monster> monsters, List<Puzzle> puzzles)
    {
        _monsters = monsters;
        _puzzles = puzzles;
        _playerCharacter = new Creature();
        _victoryGoal = 100;
    }
    public void Run()
    {
        List<Monster> monsters = _monsters;
        Console.Clear();
        int characterChoice = GetIntFromUser("Welcome to the Maze! What class would you like to play? \n1. Fighter \n2. Ranger", 1, 2);
        string playerName = GetStringFromUser("And what would you like to name your character? ");
        
        if (characterChoice == 1)
        {
        
            _playerCharacter = new MeleeCharacter(playerName);
        }
        else
        {   
            _playerCharacter = new RangedCharacter(playerName);
        }
        Console.Clear();
        Console.WriteLine("You awake in a torchlit stone room the only exit is a path.");
        while(_playerCharacter.IsAlive() && _playerCharacter.GetScore() < _victoryGoal)
        {
            Console.WriteLine("\nThe path seems to fork a short distance away.\n");
            Console.WriteLine(_playerCharacter.GetCharacterInfo());
            Console.WriteLine();
            Random random = new Random();
            //int monsterIndex = random.Next(_monsters.Count());
            //Monster monsterTemplate = 
            Monster monster = _monsters[random.Next(_monsters.Count())];
            Puzzle puzzle = _puzzles[random.Next(_puzzles.Count())];
           
            Console.WriteLine($"To the left you see {monster.GetIntro()}");
           
            Console.WriteLine($"To the right you see {puzzle.GetFlavor()}");
            int sideChoice = GetIntFromUser("Which way do you go?\n1. Left\n2. Right", 1, 2);
            
            if (sideChoice == 1)
            {
                int monsterHitpoints = monster.GetHP();
                while(monster.IsAlive())
                {
                    if (_playerCharacter.IsRanged())
                    {
                        monster.TakeDamgage(_playerCharacter.GetDamage());
                        if (monster.IsAlive())
                        {
                            _playerCharacter.TakeDamgage(monster.GetDamage());
                        }

                    }
                    else
                    {
                        _playerCharacter.TakeDamgage(monster.GetDamage());
                        monster.TakeDamgage(_playerCharacter.GetDamage());
                    }
                    if (!_playerCharacter.IsAlive())
                    {
                        break;
                    }

                }
                monster.SetHP(monsterHitpoints);
                if (_playerCharacter.IsAlive())
                {
                    Console.WriteLine(monster.GetDefeatFlavor());
                    _playerCharacter.GainScore(monster.GetDefeatScore());
                }
                else
                {
                    Console.WriteLine("You succumb to your wounds");
                }
            }
            else
            {
                puzzle.RunPuzzle(_playerCharacter);
            }
        }
        if (_playerCharacter.IsAlive())
        {
            Console.Clear();
            Console.WriteLine("You've never tasted anything so sweet as the first breath of air as you exit the maze.\nCongratulations you've WON!");
        }
        else
        {
            Console.WriteLine("Nothing is left of you but your moldering bones lost in the maze. \n DEFEAT!");
        }
    }

    private int GetIntFromUser(String prompt, int min, int max)
    {
        Console.WriteLine(prompt);
        Console.Write(">");
        int userInput = -1;
        string retry = $"Invalid input: Please enter a number between {min} and {max}.\n>";
        while(true)
        {
            try
            {
                userInput = int.Parse(Console.ReadLine());
                if(userInput >= min && userInput <= max)
                {
                    break;
                }
                else
                {
                    Console.Write(retry);    
                }
            }
            catch
            {
                Console.Write(retry);
            }
            
        }
        return userInput;
    }
    private string GetStringFromUser(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }
    
}