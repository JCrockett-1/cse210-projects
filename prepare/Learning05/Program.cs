using System;

class Program
{
    static void Main(string[] args)
    {
        Square s = new Square("red", 4);
        Rectangle r = new Rectangle("green", 4, 2);
        Circle c = new Circle("blue", 2);

        List<Shape> Shapes = new List<Shape>();
        Shapes.Add(s);
        Shapes.Add(r);
        Shapes.Add(c);

        foreach(Shape shape in Shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}