using System;

class NumbersAsText
{   // Convert integer number to text.
    static string[] singleNumbers = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
    static string[] decimalToTwenty = new string[] { "ten", "eleven", "twelve", "thirdteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
    static string[] decimalToHundred = new string[] { "twenty", "thirdty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
    static void Main()
    {
        int singleNumber = 0;
        int decimalLow = 0;
        int decimalHigh = 0;
        int hundredNumber = 0;
        string resultSingle = "";
        string resultDecimal = "";
        string resultHundred = "";
        bool isSingle = false;
        bool isDecimalLow = false;
        bool isHundred = false;
        bool isDecimalHigh = false;
        Console.WriteLine("Enter a number (0:999)");
        Console.Write("Number=");
        int number = int.Parse(Console.ReadLine());
        if (number < 0 || number > 999)
        {
            Console.WriteLine("Out of range.");
            return;
        }
        if (number / 100 >= 1)
        {
            isHundred = true;
            hundredNumber = number % 1000;
            hundredNumber /= 100;
        }
        if ((number % 100 >= 20) && (number % 100 <= 99))
        {
            isDecimalHigh = true;
            decimalHigh = number % 100;
            decimalHigh /= 10;
        }
        if ((number % 100 >= 10) && (number % 100 < 19))
        {
            isDecimalLow = true;
            decimalLow = number % 100;
            decimalLow -= 10;
        }
        Console.Write("The number is: ");
        if (number >= 1 || number == 0)
        {
            singleNumber = number % 10;
            isSingle = true;
        }
        if (isSingle == true && isDecimalLow == false && isDecimalHigh == false && isHundred == false)
        {
            resultSingle = SingleNumber(singleNumber);
            Console.WriteLine("{0}", UpperCaseFirst(resultSingle));
        }
        if (isSingle == true && isDecimalLow == true && isDecimalHigh == false && isHundred == false)
        {
            resultDecimal = DecimalToTwenty(decimalLow);
            Console.WriteLine("{0}", UpperCaseFirst(resultDecimal));
        }
        if (isSingle == true && isDecimalLow == false && isDecimalHigh == true && isHundred == false)
        {
            resultSingle = SingleNumber(singleNumber);
            resultDecimal = DecimalToHundred(decimalHigh);
            if (resultSingle == "zero")
            {
                Console.WriteLine("{0}", UpperCaseFirst(resultDecimal));
            }
            else
            {
                Console.WriteLine("{0}", UpperCaseFirst(resultDecimal + " " + resultSingle));
            }
        }
        if (isSingle == true && isDecimalLow == false && isDecimalHigh == false && isHundred == true)
        {
            resultHundred = HundredNumber(hundredNumber);
            resultSingle = SingleNumber(singleNumber);
            if (resultSingle != "zero")
            {
                Console.WriteLine("{0}", UpperCaseFirst(resultHundred + " and " + resultSingle));
            }
            else
            {
                Console.WriteLine("{0}", UpperCaseFirst(resultHundred));
            }
        }
        if (isSingle == true && isDecimalLow == true && isDecimalHigh == false && isHundred == true)
        {
            resultHundred = HundredNumber(hundredNumber);
            resultDecimal = DecimalToTwenty(decimalLow);
            Console.WriteLine("{0}", UpperCaseFirst(resultHundred + " and " + resultDecimal));
        }
        if (isSingle == true && isDecimalLow == false && isDecimalHigh == true && isHundred == true)
        {
            resultHundred = HundredNumber(hundredNumber);
            resultDecimal = DecimalToHundred(decimalHigh);
            resultSingle = SingleNumber(singleNumber);
            if (resultSingle == "zero")
            {
                Console.WriteLine("{0}", UpperCaseFirst(resultHundred + " and " + resultDecimal));
            }
            else
            {
                Console.WriteLine("{0}", UpperCaseFirst(resultHundred + " and " + resultDecimal + " " + resultSingle));
            }
        }
    }

    private static string HundredNumber(int hundredNumber)
    {
        string result = "";
        for (int i = 1; i < singleNumbers.Length; i++)
        {

            if (hundredNumber == i)
            {
                result = singleNumbers[i] + " hundred";
            }
        }
        return result;
    }

    private static string DecimalToHundred(int number)
    {
        string result = "";
        for (int i = 0; i < decimalToHundred.Length + 2; i++)
        {
            if (number == i)
            {
                result = decimalToHundred[i - 2];
            }
        }
        return result;
    }

    private static string DecimalToTwenty(int number)
    {
        string result = "";

        for (int i = 0; i < decimalToTwenty.Length; i++)
        {
            if (number == i)
            {
                result = decimalToTwenty[i];
            }
        }
        return result;
    }

    private static string SingleNumber(int number)
    {
        string result = "";
        for (int i = 0; i < singleNumbers.Length; i++)
        {
            if (number == i)
            {
                result = singleNumbers[i];
            }
        }
        return result;
    }

    static string UpperCaseFirst(string stringNumber)
    {
        return char.ToUpper(stringNumber[0]) + stringNumber.Substring(1);
    }
}

