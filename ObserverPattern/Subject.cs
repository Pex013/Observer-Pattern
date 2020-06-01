using System;
using System.Collections.Generic;
using System.Text;
using ObserverPattern.Interfaces;

namespace ObserverPattern
{
    public class Subject : ISubject
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        private string ProductName { get; }
        private int ProductPrice { get; }
        private string Availability { get; set; }

        public Subject(string productName, int productPrice, string availability)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            Availability = availability;
        }

        public string GetAvailability()
        {
            return Availability;
        }

        public void SetAvailability(string availability)
        {
            this.Availability = availability;
            Console.WriteLine("Availability changed from Out of Stock to Available.");
            NotifyObservers();
        }

        public void RegisterObserver(IObserver observer)
        {
            Console.WriteLine($"Observer Added : {((Observer)observer).UserName}");
            _observers.Add(observer);
        }

        public void NotifyObservers()
        {
            Console.WriteLine($"Product : {ProductName}, Price : {ProductPrice} is now available. So notifying all registered users.\n");
            foreach (var observer in _observers)
            {
                observer.Update(Availability);
            }
        }
    }
}