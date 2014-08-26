using System;

class PrimeNumberCheck
{
    static void Main()
    {   // Check for prime numbers into range (1 to 100).
        Console.WriteLine("Enter an integer number N (N<=100).");
        Console.Write("N=");
        int number = int.Parse(Console.ReadLine());
        if (number > 100)
        {
            Console.WriteLine("Out of range (N>100).");
            return;
        }
        int count = 0;
        bool isPrime = true;
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
            if (count > 1)
            {
                isPrime = false;
                break;
            }
        }
        Console.WriteLine("Result is: {0}", isPrime);
    }
}
