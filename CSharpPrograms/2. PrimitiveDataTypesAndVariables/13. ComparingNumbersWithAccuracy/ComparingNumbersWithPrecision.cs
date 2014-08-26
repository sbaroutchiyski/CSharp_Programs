using System;

class ComparingNumbersWithPrecision
{
    static void Main()
    {   // Compare two double numbers with precision eps=0.000001
        Console.WriteLine("Enter two real numbers.");
        Console.Write("First number=");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Second number=");
        double secondNumber = double.Parse(Console.ReadLine());
        double difference = 0;
        decimal precision = 0.000001m;
        bool result;
        if (firstNumber >= secondNumber)
        {
            difference = Math.Abs(firstNumber - secondNumber);
        }
        else
        {
            difference = Math.Abs(secondNumber - firstNumber);
        }
        result = ((decimal)difference - precision) <= precision;
        Console.WriteLine("Result is: {0}", result);
    }
}
