using System;

public class Circle: Shape
{
    private double _circle;

    public Circle(string color, double circle) : base(color)
    {
        _circle = circle;
    }
    public override double GetArea()
    {
        return _circle * _circle * Math.PI;
    }
}