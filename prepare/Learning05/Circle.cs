public class Cricle : Shape
{
    private double _radius;
    public Cricle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.Pow(_radius * Math.PI,2);
    }
}