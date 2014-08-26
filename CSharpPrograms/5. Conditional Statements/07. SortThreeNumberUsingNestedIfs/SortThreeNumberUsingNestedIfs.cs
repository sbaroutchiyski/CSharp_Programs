using System;

class SortThreeNumberUsingNestedIfs
{
    static void Main()
    {   // Enters three real numbers and prints them sorted in descending order. 
        Console.WriteLine("Enter three numbers (A,B,C).");
        Console.Write("A=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("B=");
        double b = double.Parse(Console.ReadLine());
        Console.Write("C=");
        double c = double.Parse(Console.ReadLine());
        int flag = 0;
        if (a >= b && a >= c && flag == 0)
        {
            if (b >= c)
            {
                Console.WriteLine("{0},{1},{2}", a, b, c);
            }
            if (b < c)
            {
                Console.WriteLine("{0},{1},{2}", a, c, b);
            }
            flag = 1;
        }
        if (b >= a && b >= c && flag == 0)
        {
            if (a >= c)
            {
                Console.WriteLine("{0},{1},{2}", b, a, c);
            }
            if (a < c)
            {
                Console.WriteLine("{0},{1},{2}", b, c, a);
            }
            flag = 1;
        }
        if (c >= a && c >= b && flag == 0)
        {
            if (a >= b)
            {
                Console.WriteLine("{0},{1},{2}", c, a, b);
            }
            if (a < b)
            {
                Console.WriteLine("{0},{1},{2}", c, b, a);
            }
            flag = 1;
        }
    }
}

