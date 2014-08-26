using System;
using System.Text;

class PrintIsoscelesTriangle
{
    static void Main()
    {  // Print isosceles triangle.
        Console.OutputEncoding = Encoding.UTF8; // To see copyright symbol correctly change your current font to "Lucida Console" in command prompt.
        char symbol = '\u00A9';
        int middle = 3;
        for (int range = 0; range < 3; range++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (j == middle - range || j == middle + range)
                {
                    Console.Write(symbol);
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
        for (int i = 0; i < 7; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(symbol);
            }
            else
            {
                Console.Write(' ');
            }
        }
        Console.WriteLine();
    }
}

