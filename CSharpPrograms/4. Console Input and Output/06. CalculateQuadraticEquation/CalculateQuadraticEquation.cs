using System;

class CalculateQuadraticEquation
{
    static void Main()
    {   // Calculate quadratic equation. (X1 and X2 real roots)
        double x1, x2, d;
        Console.WriteLine("Enter coeficients a,b and c of quadratic equation.");
        Console.Write("a=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b=");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c=");
        double c = double.Parse(Console.ReadLine());
        d = (b * b) - (4 * a * c);
        if (d >= 0)
        {
            x1 = (-b - Math.Sqrt(d)) / (2 * a);
            x2 = (-b + Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("x1={0},x2={1}", x1, x2);
        }
        else
        {
            Console.WriteLine("There are no real roots.");
        }
    }
}

