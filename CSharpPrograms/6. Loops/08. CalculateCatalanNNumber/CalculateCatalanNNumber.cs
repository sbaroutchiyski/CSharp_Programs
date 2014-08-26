using System;
using System.Numerics;

class CalculateCatalanNNumber
{
    static void Main()
    {   // Calculates the nth Catalan number by given n (1 < n < 100). 
        Console.WriteLine("Enter an integer number N.");
        Console.Write("N=");
        int number = int.Parse(Console.ReadLine());
        if (number < 1 || number > 100)
        {
            Console.WriteLine("Out of range.");
            return;
        }
        BigInteger nominator = 1;
        BigInteger firstDemoninator = 1;
        BigInteger secondDenominator = 1;
        BigInteger catalanNumber;
        for (int i = 1; i <= 2 * number; i++)
        {
            if (i <= number)
            {
                secondDenominator *= i;
            }
            nominator *= i;
        }
        for (int j = 1; j <= number + 1; j++)
        {
            firstDemoninator *= j;
        }
        catalanNumber = nominator / (firstDemoninator * secondDenominator);
        Console.WriteLine("Catalan({0})={1}", number, catalanNumber);
    }
}

