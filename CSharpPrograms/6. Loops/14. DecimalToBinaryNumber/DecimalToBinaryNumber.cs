using System;

class DecimalToBinaryNumber
{
    static void Main()
    {   // Converts an integer number to its binary representation. 
        Console.WriteLine("Enter an integer numbers.");
        Console.Write("Number=");
        int number = int.Parse(Console.ReadLine());
        string reversed = "";
        string binary = "";
        if (number == 0)
        {
            Console.WriteLine("Binary representation is: {0}", new string('0', 32));
            return;
        }
        while (number > 0)
        {
            if (number % 2 == 0)
            {
                reversed += '0';
            }
            else
            {
                reversed += '1';
            }
            number /= 2;
        }
        for (int i = 0; i < reversed.Length; i++)
        {
            binary += reversed[reversed.Length - i - 1];
        }
        Console.WriteLine("Binary representation is: {0}", binary.PadLeft(32, '0'));
    }
}

