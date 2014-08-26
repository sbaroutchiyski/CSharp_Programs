using System;

class CalculatePerimeterAndAreaOfCircle
{
    static void Main()
    {   // Calculate perimeter and area of a circle.
        Console.WriteLine("Enter the circle radius.");
        Console.Write("Radius=");
        double radius = double.Parse(Console.ReadLine());
        double area = Math.PI * Math.Pow(radius, 2);
        double perimeter = 2 * Math.PI * radius;
        Console.WriteLine("Perimeter is: {0:f2}", perimeter);
        Console.WriteLine("Area is: {0:f2}", area);     
    }
}

