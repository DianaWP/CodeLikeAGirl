using System;

namespace CodeLikeaGirl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please name a mode of transport");
            var vehicle = Console.ReadLine();
            Console.WriteLine("Please pick a destination");
            var destination = Console.ReadLine();
            Console.WriteLine("Whats your favourited mythical creature");
            var creature = Console.ReadLine();
            
            vehicle = vehicle.Trim();
            destination = destination.Trim();
            creature = creature.Trim();

            Console.WriteLine($"You hopped into your {vehicle} and headed off to {destination} to find the last living {creature}");
        

        }
    }
}
