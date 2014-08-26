using System;

class PrintNullValues
{
    static void Main()
    {   // Print the null and non-null values.
        int? firstNumber = null;
        double? secondNumber = null;
        Console.WriteLine("Fisrt number={0}, Second number={1}", firstNumber, secondNumber);
        firstNumber = 77;
        secondNumber = 12.345;
        Console.WriteLine("Fisrt number={0}, Second number={1}", firstNumber, secondNumber);
    }
}

