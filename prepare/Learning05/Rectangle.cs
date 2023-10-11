public class Rectangle : Shape
{
    private double _lSide;
    private double _hSide;
    public Rectangle(string color, double lSide, double hSide) : base(color)
    {
        _lSide = lSide;
        _hSide = hSide;
    }

    public override double GetArea()
    {
        return _lSide * _hSide;
    }
}