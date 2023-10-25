using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello FinalProject World!");
        List<Monster> monsters = new List<Monster>();
        List<Puzzle> puzzles = new List<Puzzle>();
        MazeManager mazeManager = new MazeManager(monsters, puzzles);
        mazeManager.Run();


    }
    public List<Monster> MakeMonsters()
    {
        List<Monster> monsters = new List<Monster>();

        //Ogre
        Monster ogre = new Monster(5, 10, 1, 15, 15, 4, "The shadow of a hulking brute looms in the doorway", "The smelly ogre lies dead at your feet", "ogre");
        monsters.Add(ogre);
        //Goblin
        Monster goblin = new Monster(5, 5, 3, 15, 5, 5, "A six beedy red eyes stare at you from the darkenss", "Three small wiry goblins lay at your feet", "3 Goblins");
        monsters.Add(goblin);

        return monsters;
    } 
    public List<Puzzle> MakePuzzles()
    {
        List<Puzzle> puzzles = new List<Puzzle>();
        return puzzles;
    }  
}