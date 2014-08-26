using System;

class BitExchangeAdvanced
{
    static void Main()
    {   // Exchange consecutive random bits of an iteger number.
        Console.WriteLine("Enter an integer number.");
        Console.Write("Number=");
        long number = long.Parse(Console.ReadLine());
        long oldNumber = number;
        Console.WriteLine("Enter P-bit position."); // (p=0 to p=15) or (p=16 to p=31) 
        Console.Write("P=");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Q-bit position."); // (q=0 to q=15) or (q=16 to q=31)
        Console.Write("Q=");
        int q = int.Parse(Console.ReadLine());
        if (p > q)
        {
            Console.WriteLine("(Q) becomes rightmost bit. (P) becomes leftmost bit.");
        }
        else
        {
            Console.WriteLine("(P) becomes rightmost bit. (Q) becomes leftmost bit.");
        }
        Console.WriteLine("How many bits (K) do you want to exchange?"); // (k>=1 and k<=16)
        Console.Write("K=");
        int k = int.Parse(Console.ReadLine());
        long tempLeft = 0;
        long tempRight = 0;
        long[] numberRightPart = new long[k];
        long[] numberLeftPart = new long[k];
        int leftBitPosition = 0;
        int rightBitPosition = 0;
        if (k + q > 32 || k + p > 32 || k + q < 0 || k + p < 0)
        {
            Console.WriteLine("Out of range.");
            return;
        }
        if ((q < 15 && p < 15) || (q >= 16 && p >= 16))
        {
            Console.WriteLine("Overlapping.");
            if (q >= 16 && p >= 16)
            {
                Console.Write("(P>16,Q>16)\n");
            }
            else
            {
                Console.Write("(P<16,Q<16)");
            }
            return;
        }

        if (q < 16 || p > 16)
        {
            if ((q + k > 16))
            {
                Console.WriteLine("Overlapping (K+Q>16).");
                return;
            }
        }
        else if (q > 16 || p < 16)
        {
            if ((p + k > 16))
            {
                Console.WriteLine("Overlapping (K+P>16).");
                return;
            }
        }
        for (int i = 0; i < k; i++)
        {

            if (p > q)
            {
                tempLeft = number >> (i + p) & 1;
                tempRight = number >> (i + q) & 1;
                leftBitPosition = p;
                rightBitPosition = q;
            }
            else
            {
                tempLeft = number >> (i + q) & 1;
                tempRight = number >> (i + p) & 1;
                leftBitPosition = q;
                rightBitPosition = p;
            }
            numberRightPart[i] = tempRight; // lower part
            numberLeftPart[i] = tempLeft;
        }
        for (int i = 0; i < k; i++)
        {
            if (numberRightPart[i] == 1)
            {
                number = number | (uint)(1 << leftBitPosition + i);
            }
            else
            {
                number = number & (uint)(~(1 << leftBitPosition + i));
            }
        }
        for (int i = 0; i < k; i++)
        {

            if (numberLeftPart[i] == 1)
            {
                number = number | (uint)(1 << rightBitPosition + i);
            }
            else
            {
                number = number & (uint)(~(1 << rightBitPosition + i));
            }
        }
        Console.WriteLine("Old Number={0} ({1})", oldNumber, Convert.ToString(oldNumber, 2).PadLeft(32, '0'));
        Console.WriteLine("New Number={0} ({1})", number, Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}




