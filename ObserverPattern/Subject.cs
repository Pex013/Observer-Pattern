using System;
using System.Collections.Generic;
using System.Text;
using ObserverPattern.Interfaces;

namespace ObserverPattern
{
    public class Subject : ISubject
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        private string _availability;
        private string ProductName { get; }
        private int ProductPrice { get; }

        public Subject(string productName, int productPrice)
        {
            ProductName = productName;
            ProductPrice = productPrice;
        }

        public string Availability
        {
            get => _availability;
            set
            {
                //if (_availability == value) return;
                _availability = value;
                Console.WriteLine("Availability changed from Out of Stock to Available.");
                NotifyObservers();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            Console.WriteLine($"Observer Added : {observer.UserName}");
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