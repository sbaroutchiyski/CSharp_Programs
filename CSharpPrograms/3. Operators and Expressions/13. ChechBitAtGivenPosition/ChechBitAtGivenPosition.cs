using System;

class ChechBitAtGivenPosition
{
    static void Main()
    {   // Returns if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1
        Console.WriteLine("Enter an integer number (N).");
        Console.Write("N=");
        int number = int.Parse(Console.ReadLine());
        int oldNumber = number;
        bool isTrue = false;
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
        if (number == 1)
        {
            isTrue = true;
        }
        Console.WriteLine("Bit @ p={0}", isTrue);
    }
}

