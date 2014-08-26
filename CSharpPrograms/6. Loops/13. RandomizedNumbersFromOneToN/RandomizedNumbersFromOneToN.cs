using System;

class RandomizedNumbersFromOneToN
{
    static void Main()
    {   // Enters an integer number N and prints the numbers 1, 2, …, n in random order. 
        Console.WriteLine("Enter the number's count N.");
        Console.Write("N=");
        int n = int.Parse(Console.ReadLine());
        Random Generator = new Random();
        string numbers = "";
        for (int i = 0; i < n; i++)
        {
            numbers += Generator.Next(1, n + 1) + ", ";
        }
        Console.WriteLine("Result: {0}", numbers.Remove(numbers.Length - 2));
    }
}

