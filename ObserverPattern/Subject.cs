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
            Console.WriteLine(@"Observer Added : {0}", ((Observer)observer).UserName);
            _observers.Add(observer);
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            Console.WriteLine("Product : {0}, Price : {1} is now available. So notifying all registered users.\n", ProductName, ProductPrice);
            foreach (var observer in _observers)
            {
                observer.Update(Availability);
            }
        }
    }
}