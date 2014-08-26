using System;

class PrintFormattedNumbers
{
    static void Main()
    {   // Print three numbers using different formats.
        Console.WriteLine("Enter three numbers.\n");
        Console.WriteLine("Enter an integer number A (0 <= A <= 500).");
        Console.Write("A=");
        int a = int.Parse(Console.ReadLine());
        if (a < 0 || a > 500)
        {
            Console.WriteLine("Out of range.");
            return;
        }
        Console.WriteLine("Enter a double number B");
        Console.Write("B=");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a double number C.");
        Console.Write("C=");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("\n|{0,-10:X}|{1,10}|{2,10:0.00}|{3,-10:0.000}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
    }
}

