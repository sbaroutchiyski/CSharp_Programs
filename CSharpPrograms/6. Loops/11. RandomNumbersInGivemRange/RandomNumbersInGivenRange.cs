using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {   // Enters 3 integers n, min and max (min ≤ max) and prints n random numbers in the range [min...max].
        Console.WriteLine("Enter three integers: N, Min and Max."); // N - count of numbers, Min - minimal number, Max - maximal number.
        Console.Write("N=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Min=");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Max=");
        int max = int.Parse(Console.ReadLine());
        if (min > max)
        {
            Console.WriteLine("Incorrect data.");
            return;
        }
        Random generator = new Random();
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ", generator.Next(min, max + 1));
        }
        Console.WriteLine();
    }
}

