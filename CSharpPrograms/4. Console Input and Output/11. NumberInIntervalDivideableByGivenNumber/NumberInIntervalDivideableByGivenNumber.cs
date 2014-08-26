using System;

class NumberInIntervalDivideableByGivenNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a range of integer numbers.");
        Console.Write("Start number=");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("End number=");
        int secondNumber = int.Parse(Console.ReadLine());
        string numbers = "";
        int numberCounts = 0;

        for (int i = firstNumber; i <= secondNumber; i++)
        {
            if (i % 5 == 0)
            {
                numbers = numbers + i + ", ";
                numberCounts++;
            }
        }
        Console.WriteLine("Numbers count P: {0}", numberCounts);
        Console.Write("Numbers are: ");
        Console.Write("{0} \n", numbers.Remove(numbers.Length - 2));
    }
}

