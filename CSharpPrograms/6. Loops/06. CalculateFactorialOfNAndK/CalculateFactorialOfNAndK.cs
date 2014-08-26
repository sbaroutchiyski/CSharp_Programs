using System;
using System.Numerics;

class CalculateFactorialOfNAndK
{
    static void Main()
    {   // Calculates n! / k! for given n and k (1 < k < n < 100).
        Console.WriteLine("Enter two integer numbers (0 < K < N < 100).");
        Console.Write("N=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K=");
        int k = int.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        BigInteger result;
        if (n < 0 || k < 0 || n == k || n > 100 || k > 100)
        {
            Console.WriteLine("Incorrect data.");
            return;
        }
        for (int i = 1; i <= n; i++)
        {
            if (i <= k)
            {
                kFactorial *= i;
            }
            nFactorial *= i;
        }
        result = nFactorial / kFactorial;
        Console.WriteLine("Result: {0}", result);
    }
}

