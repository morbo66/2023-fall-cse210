using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep5 World!"); 
        
        DisplayWelcome();
        string name = PromptUserName();
        int favNum = PromptUserNumber();
        int favSquare = SquareNumber(favNum);
        DisplayResult(favSquare, name);

    }

    static void DisplayWelcome ()
    {
        Console.WriteLine("Welcome to the program!");

    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }
    static int SquareNumber(int num)
    {
        int square = num * num;
        return square;
    }
    static void DisplayResult(int square, string name)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }
}