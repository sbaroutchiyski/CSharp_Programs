using System;

class ExtractRandomBitOfInteger
{
    static void Main()
    {   // Extracts from given integer n the value of given bit at index p. 
        Console.WriteLine("Enter an integer number (N).");
        Console.Write("N=");
        int number = int.Parse(Console.ReadLine());
        int oldNumber = number;
        Console.WriteLine("Enter the index P (P >= 0 or P <= 31)");
        Console.Write("P=");
        int bitIndex = int.Parse(Console.ReadLine());
        if (bitIndex < 0 || bitIndex > 31)
        {
            Console.WriteLine("Out of range.");
            return;
        }
        number = number >> bitIndex & 1;
        Console.WriteLine("Binary representation: {0}", Convert.ToString(oldNumber, 2).PadLeft(32, '0'));
        Console.WriteLine("Bit @ p={0}", number);
    }
}

