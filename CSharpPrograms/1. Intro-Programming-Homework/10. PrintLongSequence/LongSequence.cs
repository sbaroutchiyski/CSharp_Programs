using System;

class LongSequence
{
    static void Main()
    {   // Print the first 1000 members of the sequence: 2,-3,4,-5,6,-7,.....
        int positiveNumber = 0;
        int negativeNumber = -1;
        for (int i = 0; i < 500; i++)
        {
            Console.Write("{0} {1} ", positiveNumber += 2, negativeNumber -= 2);
        }
        Console.WriteLine();
    }
}

