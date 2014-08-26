using System;

class CheckPointInToCircle
{
    static void Main()
    {   // Checks coordinates of a point. If the point's positon is inside the defined circle result is true.
        Console.WriteLine("Enter the point's coordinates(X,Y)");
        Console.Write("X=");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Y=");
        double y = double.Parse(Console.ReadLine());
        double radius = 2;
        double result = Math.Pow(x, 2) + Math.Pow(y, 2) - Math.Pow(radius, 2); // Circle equation => (x - a)^2 + (y - b)^2 = r^2 
        bool insideCircle = false;
        if (result < 0)
        {
            Console.WriteLine("Point[{0},{1}] is inside the circle.", x, y); // Circle coordinates a=0,b=0, radius=2
            insideCircle = true;
        }
        if (result > 0)
        {
            Console.WriteLine("Point[{0},{1}] is out of the circle.", x, y);
        }
        if (result == 0)
        {
            Console.WriteLine("Point[{0},{1}] is on the circle radius.", x, y);
            insideCircle = true;
        }
        Console.WriteLine("Result is: {0}", insideCircle);
    }
}
