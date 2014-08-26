using System;

class PrintBeerTime
{
    static void Main()
    {   // Print Beer or Non-beer time.
        Console.WriteLine("Enter the time in format (hh:mm tt)"); // Example: 12:45 AM or 01:02 PM
        Console.Write("Beer Time=");
        string beerHours = Console.ReadLine();
        DateTime beerAm = DateTime.Parse("3:00 AM");
        DateTime beerPm = DateTime.Parse("1:00 PM");
        DateTime beerTime;
        if (DateTime.TryParse(beerHours, out beerTime))
        {
            if (beerTime <= beerAm || beerTime >= beerPm)
            {
                Console.WriteLine("BEER TIME!");
            }
            else
            {
                Console.WriteLine("Non-Beer time.");
            }
        }
        else
        {
            Console.WriteLine("Invalid time.");
        }
    }
}

