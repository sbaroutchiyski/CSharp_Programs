using System;

class CalculateRectanglePerimeterAndArea
{
    static void Main()
    {   // Calculate the perimeter and the area of a rectangle.
        Console.WriteLine("Enter rectangle's width and height.");
        Console.Write("Width=");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Height=");
        double height = double.Parse(Console.ReadLine());
        double perimeter = 0;
        double area = 0;
        area = width * height;
        perimeter = (2 * width) + (2 * height);
        Console.WriteLine("Perimeter is: {0}", perimeter);
        Console.WriteLine("Area is: {0}", area);
    }
}
