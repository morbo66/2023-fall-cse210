using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning04 World!");
        Assignment a1 = new Assignment("William Henderson", "math");
        Console.WriteLine(a1.GetSummary());

        Mathassignment a2 = new Mathassignment("Anthony Reber", "Multiplication", "2.3", "9-56");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomewordList());

        WritingAssignment a3 = new WritingAssignment("Alicia Franklyn", "English", "How I became a 30 foot long pencil");
        Console.WriteLine(a3.GetWritingInformation());
        

    }
}