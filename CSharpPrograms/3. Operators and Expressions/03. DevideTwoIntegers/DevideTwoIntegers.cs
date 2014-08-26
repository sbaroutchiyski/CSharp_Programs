using System;

class DevideTwoIntegers
{
    static void Main()
    {   // Checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
        Console.WriteLine("Enter a number.");
        Console.Write("Number=");
        int number = int.Parse(Console.ReadLine());
        bool isDevided = false;
        if (number % 5 == 0 && number % 7 == 0 && number != 0)
        {
            isDevided = true;
        }
        Console.WriteLine("Result is: {0}", isDevided);
    }
}

