using System;
using System.Numerics;

class FindTrialingZeroesOfNumber
{
    static void Main()
    {   // Calculate how many zeroes present at the end of a number.
        BigInteger nFactorial = 1;
        BigInteger  digit = 10;
        int number;
        int countZeroes = 0;
        Console.WriteLine("Enter positive integer (N>5)."); // if N=4 (N!=24 => no zeroes)
        Console.Write("N=");
        number = int.Parse(Console.ReadLine());
        if (number < 0 || number < 5)
        {
            Console.WriteLine("Incorrect data.");
            return;
        }
        for (int i = 1; i <= number; i++)
        {
            nFactorial *= i;
        }
        Console.WriteLine("({0})!= {1}", number, nFactorial);
        while (nFactorial % digit == 0)
        {
            digit *= 10;
            countZeroes++;
        }
        Console.WriteLine("Trialing zeroes: {0}", countZeroes);
    }
}

