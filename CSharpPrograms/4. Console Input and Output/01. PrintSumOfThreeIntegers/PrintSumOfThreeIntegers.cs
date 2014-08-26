using System;

class PrintSumOfThreeIntegers
{
    static void Main()
    {   // Print the sum of three integer numbers.
        Console.WriteLine("Enter three integer numbers.");
        Console.Write("A=");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("B=");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("C=");
        int thirdNumber = int.Parse(Console.ReadLine());
        int sum = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine("Sum={0}", sum);
    }
}

