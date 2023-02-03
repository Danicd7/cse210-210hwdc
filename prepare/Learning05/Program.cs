using System;

class Program
{
    static void Main(string[] args)
    {
        // Notice that the list is a list of "Shape" objects. That means
        // you can put any Shape objects in there, and also, any object where
        // the class inherits from Shape
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 6);

        foreach (Shape s in shapes)
        {
            // Notice that all shapes have a GetColor methos the base class
            string color = s.GetColor();

            // Notice all Shapes have a GetArea method, but the behavior is 
            // different for each type of shape
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has a area of {area}.");
        } 
    }
}