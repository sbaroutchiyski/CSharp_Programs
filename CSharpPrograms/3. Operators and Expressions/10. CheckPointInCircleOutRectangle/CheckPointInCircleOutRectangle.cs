using System;

class CheckPointInCircleOutRectangle
{
    static void Main()
    {   /* Check the point's coordinates.The area intrecepted by the circle and the rectangle is forbidden area.
        Remaining circle's area is allowed area. */
        Console.WriteLine("Enter point's coordinates X and Y.");
        Console.Write("X=");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Y=");
        double y = double.Parse(Console.ReadLine());
        double radius = 1.5;
        double result = Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2) - Math.Pow(radius, 2); // (x-a)^2+(y-b)^2=r^2 (a=1,b=1,r=1.5)
        bool insideCircle = false;
        bool insideRectancle = false;
        if (result <= 0)
        {
            insideCircle = true;
        }
        if (x >= -1 && x <= 5 && y >= -1 && y <= 1)
        {
            insideRectancle = true;
        }
        if (insideCircle == true && insideRectancle == false)
        {
            Console.WriteLine("Result: yes");
        }
        else
        {
            Console.WriteLine("Result: no");
        }
    }
}
