using System;

class FindTheBiggestOfThreeNumbers
{
    static void Main()
    {   // Finds the biggest of three numbers.
        Console.WriteLine("Enter three numbers (A,B,C)");
        Console.Write("A=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("B=");
        double b = double.Parse(Console.ReadLine());
        Console.Write("C=");
        double c = double.Parse(Console.ReadLine());
        double greater = 0;
        if (a >= b)
        {
            greater = a;
        }
        else
        {
            greater = b;
        }
        if (greater <= c)
        {
            greater = c;
        }
        Console.WriteLine("The greater number: {0}", greater);
    }
}

