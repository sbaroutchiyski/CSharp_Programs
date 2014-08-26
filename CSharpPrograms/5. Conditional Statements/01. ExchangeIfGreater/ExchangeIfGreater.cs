using System;

class ExchangeIfGreater
{
    static void Main()
    {   // Exchange two numbers.
        Console.WriteLine("Enter two numbers A and B.");
        Console.Write("A=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("B=");
        double b = double.Parse(Console.ReadLine());
        double c;
        if (a > b)
        {
            c = a;
            a = b;
            b = c;
        }
        Console.WriteLine("A={0},B={1}", a, b);
    }
}

