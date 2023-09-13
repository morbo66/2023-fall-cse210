using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random ();
        int targetNumber = randomGenerator.Next(1, 101);
        Console.WriteLine ($"{targetNumber}");
        int guessNumber = 0;

        Console.WriteLine("Can you guess the magic number? ");
        do
        {
            guessNumber = int.Parse(Console.ReadLine());
            if (targetNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (targetNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("You guessed it!");
            }
        }while (guessNumber != targetNumber);
        

    }
}