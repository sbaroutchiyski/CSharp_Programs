using System;

class WeightOfManOnTheMoon
{
    static void Main()
    {   // Calculate the weight of the man on the Moon.
        Console.WriteLine("Enter your weight on the Earth.");
        Console.Write("Weight(kg)=");
        double weight = double.Parse(Console.ReadLine());
        weight *= 0.17;
        Console.WriteLine("Your weight on the Moon will be {0}kg", weight);
    }
}

