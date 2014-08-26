using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrintSumOfFiveNumbers
{
    static void Main()
    {
        double[] numbers = new double[5];
        double sum = 0;
        int index = 0;
        Console.WriteLine("Enter five numbers on the same line separated by space.");
        Console.Write("Numbers: ");
        string textNumbers = Console.ReadLine();
        for (int i = 0; i < 5; i++)
        {
            string tempNumber = "";
            for (int j = index; j < textNumbers.Length; j++)
            {
                if (textNumbers[j] != ' ')
                {
                    tempNumber += textNumbers[j];
                    
                }
                else
                {
                    index = j + 1;
                    break;
                }
            }
            numbers[i] = double.Parse(tempNumber);
            sum += numbers[i];
        }
        Console.WriteLine("The sum is: {0}",sum);
    }
}

