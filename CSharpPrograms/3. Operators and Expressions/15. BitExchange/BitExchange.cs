using System;

class BitExchange
{
    static void Main()
    {   // Exchange bits 3,4, and 5 with 24,25 and 26.
        long[] numberLeftPart = new long[3];
        long[] numberRightPart = new long[3];
        Console.WriteLine("Enter an integer number.");
        Console.Write("Number=");
        long number = long.Parse(Console.ReadLine());
        long oldNumber = number;
        for (int i = 0; i < 3; i++)
        {
            long tempNumberL = number;
            numberLeftPart[i] = tempNumberL >> i + 3 & 1;
            long tempNumberR = number;
            numberRightPart[i] = tempNumberR >> i + 24 & 1;
        }
        for (int i = 0; i < 3; i++)
        {
            if (numberLeftPart[i] == 1)
            {
                number = number | (uint)(1 << i + 24);
            }
            else
            {
                number = number & (uint)(~(1 << i + 24));
            }
        }
        for (int i = 0; i < 3; i++)
        {
            if (numberRightPart[i] == 1)
            {
                number = number | (uint)(1 << i + 3);
            }
            else
            {
                number = number & (uint)(~(1 << i + 3));
            }
        }
        Console.WriteLine("Old Number={0} ({1})", Convert.ToString(oldNumber, 2).PadLeft(32, '0'), oldNumber);
        Console.WriteLine("New Number={0} ({1})", Convert.ToString(number, 2).PadLeft(32, '0'), number);
    }
}
