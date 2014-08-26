
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrintMinMaxSumAverage
{
    static void Main()
    {   // Returns the minimal, the maximal number, the sum and the average of all numbers. 
        Console.WriteLine("Enter a positive integer number N(N>1).");
        Console.Write("N=");
        int n = int.Parse(Console.ReadLine());
        double[] numbers = new double[n];
        double sum = 0;
        double average = 0;
        Console.WriteLine("Enter {0} numbers.", n);
        for (int i = 0; i < n; i++)
        {
            Console.Write("N[{0}]=", i + 1);
            numbers[i] = Double.Parse(Console.ReadLine());
        }
        double max = numbers[0];
        double min = numbers[0];
        for (int i = 0; i < n; i++)
        {
            if (max < numbers[i])
            {
                max = numbers[i];
            }
            if (min > numbers[i])
            {
                min = numbers[i];
            }
            sum += numbers[i];
        }
        average = sum / n;
        Console.WriteLine("\n Min: {0}", min);
        Console.WriteLine(" Max: {0}", max);
        Console.WriteLine(" Sum: {0}", sum);
        Console.WriteLine(" Avg: {0:f2}", average);
    }
}

