using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        List<Shape> shapes = new List<Shape>();
        Square square = new Square("red", 25.5);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("yellow", 23.54, 23.43);
        shapes.Add(rectangle);

        Circle circle = new Circle("blue", 10.0);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Area: {shape.GetArea()}, Color: {shape.GetColor()}");
        }
    }
}