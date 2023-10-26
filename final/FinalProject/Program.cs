using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello FinalProject World!");
        List<Monster> monsters = new List<Monster>();
        List<Puzzle> puzzles = new List<Puzzle>();

         //Ogre
        Monster ogre = new Monster(5, 10, 1, 15, 15, 10, "The shadow of a hulking brute looms in the doorway.", "The smelly ogre lies dead at your feet", "ogre");
        monsters.Add(ogre);
        //Goblin
        Monster goblin = new Monster(5, 5, 3, 15, 5, 10, "Six beedy red eyes stare at you from the darkenss.", "Three small wiry goblins lay at your feet", "3 Goblins");
        monsters.Add(goblin);
        Puzzle math = new IntPuzzle(5,"A dusty room with writing on the far wall", "I'm odd and my square is 25 what am I?", 5, 10);
        puzzles.Add(math);
        Puzzle quote = new StringPuzzle("heart", "A damp room with writing on the the floor.", "Fill in the blank: 'The best and most beautiful things in the world cannot be seen or even touched - they must be felt with the -----'", 5,10);
        puzzles.Add(quote);
        
        MazeManager mazeManager = new MazeManager(monsters, puzzles);
        mazeManager.Run();


    }
    public List<Monster> MakeMonsters()
    {
        List<Monster> monsters = new List<Monster>();

       
        return monsters;
    } 
    public List<Puzzle> MakePuzzles()
    {
        List<Puzzle> puzzles = new List<Puzzle>();
        return puzzles;
    }  
}