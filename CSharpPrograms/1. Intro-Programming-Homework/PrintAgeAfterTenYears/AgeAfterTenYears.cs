using System;
using System.Threading;
using System.Globalization;
class AgeAfterTenYears
{
    static void Main()
    {  // Print my age after 10 years.
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg");
        Console.WriteLine(@"Enter your birthday in format ""dd/mm/YYYY"".");
        Console.Write("Birthday=");
        string oldBirthday = Console.ReadLine();
        DateTime birthday = Convert.ToDateTime(oldBirthday);
        DateTime today = DateTime.Today;
        int currentAge = 0;
        if (birthday.Month >= today.Month && birthday.Day > today.Day)
        {
            currentAge = (today.Year - birthday.Year) - 1;
            Console.WriteLine("You are {0} years old.", currentAge);
        }
        else
        {
            currentAge = today.Year - birthday.Year;
            Console.WriteLine("You are {0} years old.", currentAge);
        }
        Console.WriteLine("After 10 years you will be {0} years old", currentAge + 10);
    }
}

