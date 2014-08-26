using System;

class ConvertDecimalToHexadecimalNumber
{
    static void Main()
    {
        // Convert Decimal number to hexadecimal.
        Console.WriteLine("Enter an integer number.");
        Console.Write("Number=");
        long decimalNumber = long.Parse(Console.ReadLine());
        long remainder;
        string hexadecimalNumber = "";
        while (decimalNumber > 0)
        {
            remainder = decimalNumber % 16;
            decimalNumber /= 16;
            hexadecimalNumber += ConvertToHexadecimal(remainder);
        }
        Console.Write("Hexadecimal representation: ");
        for (int i = hexadecimalNumber.Length - 1; i >= 0; i--)
        {
            Console.Write(hexadecimalNumber[i]);
        }
        Console.WriteLine();
    }

    static string ConvertToHexadecimal(long number)
    {
        string tempNumber = "";
        switch (number)
        {
            case 0:
                tempNumber = "0";
                break;
            case 1:
                tempNumber = "1";
                break;
            case 2:
                tempNumber = "2";
                break;
            case 3:
                tempNumber = "3";
                break;
            case 4:
                tempNumber = "4";
                break;
            case 5:
                tempNumber = "5";
                break;
            case 6:
                tempNumber = "6";
                break;
            case 7:
                tempNumber = "7";
                break;
            case 8:
                tempNumber = "8";
                break;
            case 9:
                tempNumber = "9";
                break;
            case 10:
                tempNumber = "A";
                break;
            case 11:
                tempNumber = "B";
                break;
            case 12:
                tempNumber = "C";
                break;
            case 13:
                tempNumber = "D";
                break;
            case 14:
                tempNumber = "E";
                break;
            case 15:
                tempNumber = "F";
                break;
        }
        return tempNumber;
    }
}


