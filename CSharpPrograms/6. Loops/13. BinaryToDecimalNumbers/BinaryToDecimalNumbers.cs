using System;

class BinaryToDecimalNumbers
{
    static void Main()
    {   // Converts a binary integer number to its decimal form. 
        Console.WriteLine("Enter a binary number.");
        Console.Write("Number=");
        string binaryNumber = Console.ReadLine();
        if (binaryNumber.Length > 32)
        {
            Console.WriteLine("Out of range (Int32).");
            return;
        }
        int powerTwo = (int)Math.Pow(2, binaryNumber.Length - 1);
        int decimalNumber = 0;
        for (int i = 0; i < binaryNumber.Length; i++)
        {
            if (binaryNumber[i] == '1')
            {
                decimalNumber += powerTwo;
            }
            powerTwo /= 2;
        }
        Console.WriteLine("Decimal number: {0}", decimalNumber);
    }
}

