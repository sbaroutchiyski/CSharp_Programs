using System;

class EvenOrOddProductOfNumbers
{
    static void Main()
    {   // Checks whether the product of the odd elements is equal to the product of the even elements.
        Console.WriteLine("Enter the number's count N.");
        Console.Write("N=");
        int n = int.Parse(Console.ReadLine());
        int index = 0;
        int numberIndex = 0;
        int evenSum = 1;
        int oddSum = 1;
        string tempNum = "";
        int[] numbers = new int[n];
        Console.WriteLine("Enter {0} numbers on the same line separated by space.", n);
        Console.Write("Numbers: ");
        string textNumbers = Console.ReadLine() + " ";
        for (int i = numberIndex; i < textNumbers.Length; i++)
        {
            if (textNumbers[i] != ' ')
            {
                tempNum += textNumbers[i];
            }
            else
            {
                numbers[index] = int.Parse(tempNum);
                index++;
                numberIndex = i + 1;
                tempNum = "";
            }
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                oddSum *= numbers[i];
            }
            else
            {
                evenSum *= numbers[i];
            }
        }
        if (evenSum == oddSum)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Product is: {0}", evenSum);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("Odd product is: {0}", oddSum);
            Console.WriteLine("Even product is: {0}", oddSum);
        }
    }
}

