using System;

class BonusScoreOfDigits
{
    static void Main()
    {   // Applies bonus score to given score in the range [1…9]. 
        Console.WriteLine("Enter number N [0-9].");
        Console.Write("N=");
        int number = int.Parse(Console.ReadLine());
        if (number < 1 || number > 9)
        {
            Console.WriteLine("Invalid score.");
            return;
        }
        if (number == 1 || number <= 3)
        {
            number *= 10;
        }
        if (number == 4 || number <= 6)
        {
            number *= 100;
        }
        if (number == 7 || number <= 9)
        {
            number *= 1000;
        }
        Console.WriteLine("Bonus score: {0}", number);
    }
}

