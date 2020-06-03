using System;
using ObserverPattern.Interfaces;

namespace ObserverPattern
{
    public class Observer : IObserver
    {
        public string UserName { get; set; }

        public Observer(string userName, ISubject subject)
        {
            UserName = userName;
            subject.RegisterObserver(this);
        }

        public void Update(string availability)
        {
            Console.WriteLine($"Hello {UserName}, Product is now {availability} on bol.com");
        }
    }
}