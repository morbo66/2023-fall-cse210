using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();

        int userNumber = 0;

        do
        {
            Console.Write("Enter a number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }while (userNumber != 0);

        int sum = 0;
        int largest = numbers[0];
        
        foreach (int num in numbers)
        {
            sum += num;
            if (num > largest)
            {
                largest = num;
            }
        }

        
        //float listLength = numbers.Count;
        float sumf = sum;
        float average = sumf / numbers.Count;


        Console.WriteLine($"The total value of your list is: {sum}");
        Console.WriteLine($"The largest value in your list is: {largest}");
        Console.WriteLine($"The average value of your list is: {average}");

    }
}