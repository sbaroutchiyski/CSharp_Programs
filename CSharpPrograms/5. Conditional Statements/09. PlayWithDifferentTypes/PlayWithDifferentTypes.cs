using System;

class PlayWithDifferentTypes
{
    static void Main()
    {   // Increase integer and real number with 1 or concatenate string with *.
        Console.WriteLine(" Choose a type:\n");
        Console.WriteLine("  1. --> int");
        Console.WriteLine("  2. --> double");
        Console.WriteLine("  3. --> string\n");
        Console.Write("  Choice=");
        int choice = int.Parse(Console.ReadLine());
        int integerNumber;
        double realNumber;
        string text;
        if (choice == 1)
        {
            Console.Write("  Enter an integer= ");
            integerNumber = int.Parse(Console.ReadLine()) + 1;
            Console.WriteLine("  Result is: {0}", integerNumber);
        }
        if (choice == 2)
        {
            Console.Write("  Enter a real number= ");
            realNumber = Double.Parse(Console.ReadLine()) + 1;
            Console.WriteLine("  Result is: {0}", realNumber);
        }
        if (choice == 3)
        {
            Console.Write("  Enter a string= ");
            text = Console.ReadLine();
            Console.WriteLine("  Result is: {0}*", text);
        }
        if (choice <= 0 || choice > 3)
        {
            Console.WriteLine("  Invalid choice.");
            return;
        }
    }
}

