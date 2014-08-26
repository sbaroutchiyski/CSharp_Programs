using System;

class MarketingFirmRecord
{
    static void Main()
    {   // Print a data record.
        string firstName = "Ivan", lastName = "Petrov";
        byte age = 43;
        char gender = 'm';
        int idNumber = 27560003;
        Console.WriteLine(" Marketing Firm Record.\n");
        Console.WriteLine(" First name: {0}\n", firstName);
        Console.WriteLine(" Last name: {0}\n", lastName);
        Console.WriteLine(" Age: {0}\n", age);
        Console.WriteLine(" Gender: {0}\n", gender);
        Console.WriteLine(" ID number: {0}\n", idNumber);
    }
}
