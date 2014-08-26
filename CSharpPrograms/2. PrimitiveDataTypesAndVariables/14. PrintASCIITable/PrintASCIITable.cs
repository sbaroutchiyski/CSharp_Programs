using System;
using System.Text;

class PrintASCIITable
{
    static void Main()
    {   // Print extended ASCII table. 
        Console.OutputEncoding = Encoding.Unicode;
        for (int i = 0; i < 255; i++)
        {
            Console.Write("{0} ", (char)i);
        }
        Console.WriteLine();
    }
}

