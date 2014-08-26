using System;

class CheckIntegerThirdDigit
{
    static void Main()
    {   // Check the third digit(from right to left). If the digit is 7 result is true.
        Console.WriteLine("Enter a number.");
        Console.Write("Number=");
        int number = int.Parse(Console.ReadLine());
        int checkDigit = number % 1000;
        bool isSeven = false;
        if (checkDigit / 100 == 7)
        {
            isSeven = true;
            Console.WriteLine("Third digit is: {0}", checkDigit / 100);
        }
        else
        {
            Console.WriteLine("Third digit is: {0}", checkDigit / 100);
        }
        Console.WriteLine("Result: {0}", isSeven);
    }
}

