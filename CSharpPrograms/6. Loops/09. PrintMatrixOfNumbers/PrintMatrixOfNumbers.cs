using System;

class PrintMatrixOfNumbers
{
    static void Main()
    {   // Print square matrix of N x N elements.
        Console.WriteLine("Enter dimension N of square matrix.");
        Console.Write("N=");
        int n = int.Parse(Console.ReadLine());
        if (n < 1 || n > 20)
        {
            Console.WriteLine("Out of range.");
            return;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write("{0,4}", j + i);
            }
            Console.WriteLine();
        }
    }
}

