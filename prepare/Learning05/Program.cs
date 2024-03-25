using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square = new Square("purple", 5);
        Rectangle rectangle = new Rectangle("red", 3, 10);
        Circle circle = new Circle("blue", 4);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape item in shapes)
        {
            Console.WriteLine($"shape, Color: {item.GetColor()}, Area: {item.GetArea()}");
        }
    }
}