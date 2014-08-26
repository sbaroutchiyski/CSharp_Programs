using System;

class MultiplicationSign
{
    static void Main()
    {   // Shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
        Console.WriteLine("Enter three numbers (A,B,C).");
        Console.Write("A=");
        double a = double.Parse(Console.ReadLine());
        Console.Write("B=");
        double b = double.Parse(Console.ReadLine());
        Console.Write("C=");
        double c = double.Parse(Console.ReadLine());
        string sign = null;
        if (a > 0 && b > 0 && c > 0)  // +++
        {
            sign = "+";
        }
        if (a < 0 && b < 0 && c > 0) // --+
        {
            sign = "+";
        }
        if (a < 0 && b > 0 && c < 0) //-+-
        {
            sign = "+";
        }
        if (a > 0 && b > 0 && c < 0) //++-
        {
            sign = "-";
        }
        if (a > 0 && b < 0 && c > 0) //+-+
        {
            sign = "-";
        }
        if (a < 0 && b > 0 && c > 0) //-++
        {
            sign = "-";
        }
        if (a < 0 && b < 0 && c < 0) //---
        {
            sign = "-";
        }
        if (a == 0 || b == 0 || c == 0) // 0
        {
            sign = "0";
        }
        Console.WriteLine("Result: {0}", sign);
    }
}

