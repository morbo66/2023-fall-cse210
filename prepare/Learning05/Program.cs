using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning05 World!");

        Square square = new Square("red", 5.5);
        Rectangle rectangle = new Rectangle("blue", 5,4);
        Cricle cricle = new Cricle("Yellow", 2);

        Console.WriteLine(square.GetColor() + square.GetArea());
        Console.WriteLine(rectangle.GetColor() + rectangle.GetArea());
        Console.WriteLine(cricle.GetColor() + cricle.GetArea());

        List<Shape> shapes = new List<Shape>();

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(cricle);

        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetColor()} has an area of {shape.GetArea()}");
        }
    }
}