using System;

class CaclulateTrapezoidArea
{
    static void Main()
    {   // Calculate trapezoid's area by given coordinates A,B and H.
        Console.WriteLine("Enter the trapezoid's parameters.");
        Console.WriteLine("Enter the upper base (A).");
        Console.Write("A=");
        double upperBase = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the lower base (B).");
        Console.Write("B=");
        double lowerBase = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height (H).");
        Console.Write("H=");
        double height = double.Parse(Console.ReadLine());
        double area = (lowerBase + upperBase) * height * 0.5;
        Console.WriteLine("Trapezoid area is: {0}", area);
    }
}
