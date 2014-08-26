using System;

class NumberComparer
{
    static void Main()
    {   // Print the greater number.
        Console.WriteLine("Enter two  numbers.");
        Console.Write("A=");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("B=");
        double secondNumber = double.Parse(Console.ReadLine());
        double greaterNumber = firstNumber - secondNumber;
        Console.WriteLine("Greater is: {0}", greaterNumber > 0 ? firstNumber : secondNumber);
    }
}

