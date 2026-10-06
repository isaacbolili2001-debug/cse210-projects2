using System;

public class Rectangle : Shape
{
    private double _length;
    private double _with;

    public Rectangle(string color, double length, double width): base(color)
    {
        _length = length;
        _with = width;
    }

    
    public override double GetArea()
    {
        return  _length * _with;
    }
}