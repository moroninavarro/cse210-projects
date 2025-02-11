using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");


        List<Shape> shapes = new List<Shape>();


        Square square = new Square("Black", 9);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("white", 5, 6);
        shapes.Add(rectangle);


        Circle circle = new Circle("Red", 8);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
                string color = shape.GetColor();


                double area = shape.GetArea();

                Console.WriteLine($"The {color} shape has an area of {area}");

        }

    }
}