using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {   // Covert hexadecimal number to decimal.
        Console.WriteLine("Enter a hexadecimal number.");
        Console.Write("Hexadecimal=");
        string hexadecimal = Console.ReadLine();
        int maxLength = hexadecimal.Length;
        hexadecimal = hexadecimal.ToUpper();
        long decimalNumber = 0;
        for (int i = 0; i < maxLength; i++)
        {
            long power = (long)Math.Pow(16, i);
            decimalNumber += (ConvertToDecimal(hexadecimal[maxLength - i - 1]) * power);
        }
        Console.WriteLine("Decimal number: {0}", decimalNumber);
    }

    private static int ConvertToDecimal(char hexadecimal)
    {
        int number = 0;
        switch (hexadecimal)
        {
            case '0':
                number = 0;
                break;
            case '1':
                number = 1;
                break;
            case '2':
                number = 2;
                break;
            case '3':
                number = 3;
                break;
            case '4':
                number = 4;
                break;
            case '5':
                number = 5;
                break;
            case '6':
                number = 6;
                break;
            case '7':
                number = 7;
                break;
            case '8':
                number = 8;
                break;
            case '9':
                number = 9;
                break;
            case 'A':
                number = 10;
                break;
            case 'B':
                number = 11;
                break;
            case 'C':
                number = 12;
                break;
            case 'D':
                number = 13;
                break;
            case 'E':
                number = 14;
                break;
            case 'F':
                number = 15;
                break;
        }
        return number;
    }
}

