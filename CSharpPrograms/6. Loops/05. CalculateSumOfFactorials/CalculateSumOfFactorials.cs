using System;

class CalculateSumOfFactorials
{
    static void Main()
    {   // For a given two integer numbers n and x, calculates the sum S = 1 + 1!/x^1 + 2!/x^2 + … + n!/x^n. 
        Console.WriteLine("Enter two integer numbers: N and X.");
        Console.Write("N=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("X=");
        int x = int.Parse(Console.ReadLine());
        double nFactorial = 1;
        double xPower = 1;
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            nFactorial *= (i + 1);
            xPower *= x;
            sum = sum + (nFactorial / xPower);
        }
        Console.WriteLine("Sum: {0:0.00000}", 1 + sum);
    }
}

