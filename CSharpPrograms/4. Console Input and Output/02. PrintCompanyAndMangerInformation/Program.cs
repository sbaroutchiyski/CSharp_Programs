using System;

class Program
{
    static void Main()
    {   // Print Company and manager information.
        string companyName, address, webSite;
        string firstName, lastName, cPhone, mPhone, cFax, mAge;
        Console.WriteLine("   Enter the Company and Manager information.");
        Console.Write("   Company Name:");
        companyName = Console.ReadLine();
        Console.Write("   Company Address:");
        address = Console.ReadLine();
        Console.Write("   Phone Number:");
        cPhone = Console.ReadLine();
        Console.Write("   Fax Number:");
        cFax = Console.ReadLine();
        Console.Write("   Web Site:");
        webSite = Console.ReadLine();
        Console.WriteLine();
        Console.Write("   Manager first name:");
        firstName = Console.ReadLine();
        Console.Write("   Manager Last name:");
        lastName = Console.ReadLine();
        Console.Write("   Manager phone number:");
        mPhone = Console.ReadLine();
        Console.Write("   Manager age:");
        mAge = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("    Company Information.");
        Console.WriteLine("    Name:{0}", companyName);
        Console.WriteLine("    Addres:{0}", address);
        Console.WriteLine("    Phone Number:{0}", cPhone);
        Console.WriteLine("    Fax Number:{0}", cFax);
        Console.WriteLine("    Web Site:{0}", companyName);
        Console.WriteLine();
        Console.WriteLine("    Manager Information.");
        Console.WriteLine("    First Name:{0}", firstName);
        Console.WriteLine("    Last Name:{0}", lastName);
        Console.WriteLine("    Age:{0}", mAge);
        Console.WriteLine("    Phone Number:{0}", mPhone);
    }
}

