using System;

class ExchangeTwoIntValues
{
    static void Main()
    {   // Exchange the values between two Integer numbers.
        int firstNumber = 5;
        int secondNumber = 10;
        int temporaryNumber = 0;
        Console.Write("Before exchange: ");
        Console.WriteLine("A={0},B={1}", firstNumber, secondNumber);
        temporaryNumber = firstNumber;
        firstNumber = secondNumber;
        secondNumber = temporaryNumber;
        Console.Write("After exchange: ");
        Console.WriteLine("A={0},B={1}", firstNumber, secondNumber);
    }
}

