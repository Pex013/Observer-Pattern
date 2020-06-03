using System;

namespace ObserverPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var playstation = new Subject("Playstation 5", 499)
            {
                Availability = "Out of stock"
            };
            var patrick = new Observer("Patrick", playstation);
            var maikel = new Observer("Maikel", playstation);
            var menno = new Observer("Menno", playstation);

            Console.WriteLine($"Playstation 5 current state : {playstation.Availability}");
            Console.WriteLine();
            playstation.Availability = "Available";
            Console.Read();
        }
    }
}