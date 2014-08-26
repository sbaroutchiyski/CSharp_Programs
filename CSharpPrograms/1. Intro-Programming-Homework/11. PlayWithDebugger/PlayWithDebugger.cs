using System;

class PlayWithDebugger
{
    static void Main()
    {
        int numbers = 1;
        for (int i = 0; i < 1000; i++)
        {
            Console.WriteLine("{0}", numbers + i);
        }
    }
}

