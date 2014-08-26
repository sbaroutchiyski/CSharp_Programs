using System;
using System.Numerics;

class PrintFibonacciSequence
{   // Print the first (n) numbers of Fibonacci sequence.
    static void Main()
    {
        BigInteger a = -1;
        BigInteger b = 1;
        BigInteger c;
        string sequence = "";
        Console.WriteLine("Enter the number's count (n).");
        Console.Write("n=");
        int numbersCount = int.Parse(Console.ReadLine());
        Console.Write("Fibonacci sequence: ");
        for (int i = 0; i < numbersCount; i++)
        {
            c = a + b;
            a = b;
            b = c;
            sequence = sequence + c + ", ";
        }
        Console.Write("{0} \n", sequence.Remove(sequence.Length - 2));
    }
}

