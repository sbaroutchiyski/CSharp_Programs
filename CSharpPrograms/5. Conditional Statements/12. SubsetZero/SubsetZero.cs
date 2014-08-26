using System;

class SubsetZero
{
    static void Main()
    {   // We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0. 
        int[] numbers = new int[5];
        int subsetsCount = 0;
        Console.WriteLine("Enter five integer numbers N.");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("N[{0}]=", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        string numsPerTwo = "";
        string numsPerThree = "";
        string numsPerFour = "";
        string numsPerFive = "";
        for (int i = 0; i < 32; i++)
        {
            string temp = Convert.ToString(i, 2).PadLeft(5, '0');
            string newNumbers = "";
            int count = 0;
            int sum = 0;
            for (int j = 0; j < 5; j++)
            {
                if (temp[j] == '1')
                {
                    count++;
                    sum += numbers[j];
                    newNumbers += numbers[j] + ", ";
                }
            }
            if (sum == 0 && count > 1)
            {
                if (count == 2)
                {
                    numsPerTwo += newNumbers;
                    numsPerTwo = numsPerTwo.Remove(numsPerTwo.Length - 2) + "\n";
                }
                if (count == 3)
                {
                    numsPerThree += newNumbers;
                    numsPerThree = numsPerThree.Remove(numsPerThree.Length - 2) + "\n";
                }
                if (count == 4)
                {
                    numsPerFour += newNumbers;
                    numsPerFour = numsPerFour.Remove(numsPerFour.Length - 2) + "\n";
                }
                if (count == 5)
                {
                    numsPerFive += newNumbers;
                }
                subsetsCount++;
            }
        }
        if (subsetsCount > 0)
        {
            Console.WriteLine("\nSubsets: {0}", subsetsCount);
            Console.WriteLine(numsPerTwo + numsPerThree + numsPerFour + numsPerFive);
        }
        else
        {
            Console.WriteLine("No subsets.");
        }
    }
}

