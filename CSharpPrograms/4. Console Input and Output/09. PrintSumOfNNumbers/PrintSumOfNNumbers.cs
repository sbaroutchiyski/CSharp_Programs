using System;

class PrintSumOfNNumbers
{
    static void Main()
    {   // Print the sum of n numbers.
        Console.WriteLine("Enter an integer number N (N > 0).");
        Console.Write("N=");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("Insufficient numbers.");
            return;
        }
        int[] numbers = new int[n];
        int sum = 0;
        Console.WriteLine("Enter {0} numbers.", n);
        for (int i = 0; i < n; i++)
        {
            Console.Write("N[{0}]=", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
            sum += numbers[i];
        }
        Console.WriteLine("Sum is: {0}", sum);
    }
}

