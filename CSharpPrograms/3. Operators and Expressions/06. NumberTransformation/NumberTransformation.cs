using System;

class FourDigitNumber
{
    static void Main()
    {   // Perform transformation of an integer number.
        Console.WriteLine("Enter a four digit integer number.");
        Console.Write("Number=");
        string textNumber = Console.ReadLine();
        string firstDigit = "" + textNumber[0];
        string secondDigit = "" + textNumber[1];
        string thirdDigit = "" + textNumber[2];
        string fourthDigit = "" + textNumber[3];
        int sum = int.Parse(firstDigit) + int.Parse(secondDigit) + int.Parse(thirdDigit) + int.Parse(fourthDigit);
        string reversed = fourthDigit + thirdDigit + secondDigit + firstDigit;
        string lastDigitFirst = fourthDigit + firstDigit + secondDigit + thirdDigit;
        string exchangedTwoDigits = firstDigit + thirdDigit + secondDigit + fourthDigit;
        Console.WriteLine("The sum of digits is: {0}", sum);
        Console.WriteLine("Reversed number is: {0}", reversed);
        Console.WriteLine("Last Digit at first position: {0}", lastDigitFirst);
        Console.WriteLine("Exchanged second and third digit: {0}", exchangedTwoDigits);
    }
}


