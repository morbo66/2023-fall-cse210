public class MazeManager
{
    private List<Monster> _monsters;
    private List<Puzzle> _puzzles;
    public MazeManager(List<Monster> monsters, List<Puzzle> puzzles)
    {
        _monsters = monsters;
        _puzzles = puzzles;
    }
    public void Run()
    {
        Console.Clear();
        int characterChoice = GetIntFromUser("Welcome to the Maze! What class would you like to play? \n1. Fighter \n2. Ranger", 1, 2);
        string playerName = GetStringFromUser("And what would you like to name your character? ");
        if (characterChoice == 1)
        {
        
            Creature playerCharacter = new MeleeCharacter(playerName);
        }
        else
        {   
            Creature playerCharacter = new RangedCharacter(playerName);
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