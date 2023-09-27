using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning03 World!");
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimal());

        Fraction fraction2 = new Fraction(27);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimal());

        Fraction fraction3 = new Fraction(4, 34);
        Console.WriteLine(fraction3.GetBottom());
        Console.WriteLine(fraction3.GetTop());
        Console.WriteLine(fraction3.GetDecimal());
        Console.WriteLine(fraction3.GetFractionString());

        


        
    }
}