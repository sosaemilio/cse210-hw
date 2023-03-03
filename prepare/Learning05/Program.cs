using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape> {};

        shapes.Add(new Rectangle("purple", 10, 8));
        shapes.Add(new Square("black", 5));
        shapes.Add(new Circle("blue", 25));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
        }
    }
}