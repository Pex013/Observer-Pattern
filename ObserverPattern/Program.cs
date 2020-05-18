using System;
using ObserverPattern.Interfaces;

namespace ObserverPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var playstation = new Subject("Playstation 5", 499, "Out of Stock");
            var patrick = new Observer("Patrick", playstation);
            var maikel = new Observer("Maikel", playstation);
            var menno = new Observer("Menno", playstation);

            Console.WriteLine(@"Playstation 5 current state : {0}", playstation.GetAvailability());
            Console.WriteLine();
            playstation.SetAvailability("Available");
            Console.Read();
        }
    }
}