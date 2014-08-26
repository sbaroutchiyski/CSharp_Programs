using System;

class ExtractTheThirdBitOfInteger
{
    static void Main()
    {   // Extract the third bit of unsigned integer number.
        Console.WriteLine("Enter a positive integer number.");
        Console.Write("Number=");
        uint number = uint.Parse(Console.ReadLine());
        uint oldNumber = number;
        number = number >> 3 & 1;
        Console.WriteLine("Binary representation: {0}", Convert.ToString(oldNumber, 2).PadLeft(32, '0'));
        Console.WriteLine("Bit #3={0}", number);
    }
}

