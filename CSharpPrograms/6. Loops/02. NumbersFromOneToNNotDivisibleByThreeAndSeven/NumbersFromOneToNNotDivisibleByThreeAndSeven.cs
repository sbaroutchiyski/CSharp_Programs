using System;

class NumbersFromOneToNNotDivisibleByThreeAndSeven
{
    static void Main()
    {   // Prints all the numbers from 1 to n not divisible by 3 and 7.
        Console.WriteLine("Enter a positive integer number N.");
        Console.Write("N=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Result: ");
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.Write("{0} ", i);
            }
        }
        Console.WriteLine();
    }
}

