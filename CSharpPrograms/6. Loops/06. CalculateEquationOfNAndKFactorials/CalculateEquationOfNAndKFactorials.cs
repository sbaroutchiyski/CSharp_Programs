using System;
using System.Numerics;

class CalculateEquationOfNAndKFactorials
{
    static void Main()
    {   // Calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
        Console.WriteLine("Enter two integer numbers N and K (1 < K < N < 100).");
        Console.Write("N=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K=");
        int k = int.Parse(Console.ReadLine());
        if (k > n || k < 1 || n < 1 || k > 100 || n > 100 || k == n)
        {
            Console.WriteLine("Incorrect input data.");
            return;
        }
        BigInteger nominator = 1;
        BigInteger firstDenominator = 1;
        BigInteger secondDenominator = n - k;
        BigInteger denominatorProduct = 1;
        BigInteger result = 0;
        for (int i = 1; i <= n; i++)
        {
            nominator *= i;
            if (i < (n - k))
            {
                secondDenominator *= i;
            }
        }
        for (int j = 1; j <= k; j++)
        {
            firstDenominator *= j;
        }
        denominatorProduct = firstDenominator * secondDenominator;
        result = nominator / denominatorProduct;
        Console.WriteLine("Result: {0}", result);
    }
}

