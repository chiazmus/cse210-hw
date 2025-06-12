using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square(10, "red"));
        shapes.Add(new Circle(5, "blue"));
        shapes.Add(new Rectangle(4, 3, "green"));

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Area: {shape.GetArea()}");
            Console.WriteLine($"Color: {shape.GetColor()}");
        }


    }
}