using System;

class PrintNumbersFromOneToN
{
    static void Main()
    {   // Prints the numbers from 1 to N.
        Console.WriteLine("Enter a positive integer number N (N>1).");
        Console.Write("N=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Result: ");
        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine();
    }
}

