using System;

class DigitAsWord
{
    static void Main()
    {   // Convert number to text.
        Console.WriteLine("Enter an integer number (0-9)");
        Console.Write("Number=");
        int number = int.Parse(Console.ReadLine());
        string textNumber = null;
        switch (number)
        {
            case 0:
                textNumber = "Zero";
                break;
            case 1:
                textNumber = "One";
                break;
            case 2:
                textNumber = "Two";
                break;
            case 3:
                textNumber = "Three";
                break;
            case 4:
                textNumber = "Four";
                break;
            case 5:
                textNumber = "Five";
                break;
            case 6:
                textNumber = "Six";
                break;
            case 7:
                textNumber = "Seven";
                break;
            case 8:
                textNumber = "Eight";
                break;
            case 9:
                textNumber = "Nine";
                break;
            default:
                Console.WriteLine("Not a digit.");
                return;
        }
        Console.WriteLine("The number is: {0}", textNumber);
    }
}

