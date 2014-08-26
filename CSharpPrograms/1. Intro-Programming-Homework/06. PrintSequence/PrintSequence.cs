using System;

class PrintSequence
{
    static void Main()
    {   // Print the first 10 numbers of the sequence: 2, -3,4,-5,....
        int positiveNumber = 2;
        int negativeNumber = -3;
        Console.Write("Sequence: ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("{0} {1} ", positiveNumber, negativeNumber);
            positiveNumber += 2;
            negativeNumber -= 2;
        }
        Console.WriteLine();
    }
}

