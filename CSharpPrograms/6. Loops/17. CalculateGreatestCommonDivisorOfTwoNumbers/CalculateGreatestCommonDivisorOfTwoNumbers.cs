using System;

class CalculateGreatestCommonDivisorOfTwoNumbers
{
    static void Main()
    {   // Find the Greatest Common Divisor (GCD) of two Integers
        int a;
        int b;
        int c;
        int aConst;
        int bConst;
        Console.WriteLine("Enter two Integers A and B (A>B).");
        Console.Write("A=");
        a = int.Parse(Console.ReadLine());
        aConst = a;
        Console.Write("B=");
        b = int.Parse(Console.ReadLine());
        bConst = b;
        if (a < b)
        {
            Console.WriteLine("Incorrect data.");
            return;
        }
        do
        {
            c = a % b;
            a = b;
            b = c;
        }
        while (c > 0);
        Console.WriteLine("GCD({0},{1})={2}", aConst, bConst, a);
    }
}


