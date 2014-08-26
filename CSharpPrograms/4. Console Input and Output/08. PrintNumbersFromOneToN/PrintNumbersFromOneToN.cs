using System;

class PrintNumbersFromOneToN
{
    static void Main()
    {   // Print numbers from 1 to N.
        Console.WriteLine("Enter an integer number N.");
        Console.Write("N=");
        int number = int.Parse(Console.ReadLine());
        string result = "";

        for (int i = 1; i <= number; i++)
        {
            result = result + i + ", ";
        }
        Console.WriteLine("Result: {0}", result.Remove(result.Length - 2));
    }
}

