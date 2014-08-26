using System;

class PrintEvenOrOddNumber
{
    static void Main()
    {   // Checks if a given integer is even or odd.
        Console.WriteLine("Enter a number.");
        Console.Write("Number=");
        int number = int.Parse(Console.ReadLine());
        bool isOdd = false;
        if (number % 2 != 0)  // even-false , odd-true
        {
            isOdd = true;
        }
        Console.WriteLine("Result is: {0}", isOdd);
    }
}

