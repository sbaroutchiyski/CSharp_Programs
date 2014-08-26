using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {   // Modifies a number(n) to hold the value (v) at the position (p). Example: n=1,p=0,v=0 => n=0
        Console.WriteLine("Enter an integer number n.");
        Console.Write("n=");
        int number = int.Parse(Console.ReadLine());
        int oldNumber = number;
        Console.WriteLine("Enter bit position p."); // p >=0 or p <32 
        Console.Write("p=");
        int bitShift = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit value v."); // v=0 or 1
        Console.Write("v=");
        byte bitValue = byte.Parse(Console.ReadLine());
        if (bitValue > 1 || bitValue < 0)
        {
            Console.WriteLine("Incorrect bit value (v).Try again.");
            return;
        }
        if (bitShift < 0 || bitShift > 31)
        {
            Console.WriteLine("Incorrect bit shift (p).Try again.");
            return;
        }
        if (bitValue == 1)
        {
            number = number | (1 << bitShift);
        }
        else
        {
            number = number & (~(1 << bitShift));
        }
        Console.WriteLine("Old number=({0}),{1}", oldNumber, Convert.ToString(oldNumber, 2).PadLeft(32, '0'));
        Console.WriteLine("New number=({0}),{1}", number, Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}
