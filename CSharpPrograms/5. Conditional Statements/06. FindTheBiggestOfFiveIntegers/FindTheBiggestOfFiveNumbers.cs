using System;

class FindTheBiggestOfFiveNumbers
{
    static void Main()
    {   // Finds the biggest of five numbers by using only five if statements. 
        double[] numbers = new double[5];
        double greater = 0;
        Console.WriteLine("Enter five numbers N.");
        for (int i = 0; i < 5; i++)
        {
            Console.Write("N[{0}]=", i + 1);
            numbers[i] = double.Parse(Console.ReadLine());
        }
        if (numbers[0] > greater)
        {
            greater = numbers[0];
        }
        if (numbers[1] > greater)
        {
            greater = numbers[1];
        }
        if (numbers[2] > greater)
        {
            greater = numbers[2];
        }
        if (numbers[3] > greater)
        {
            greater = numbers[3];
        }
        if (numbers[4] > greater)
        {
            greater = numbers[4];
        }
        Console.WriteLine("The greater number is: {0}", greater);
    }
}

