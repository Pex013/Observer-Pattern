using System;
using ObserverPattern.Interfaces;

namespace ObserverPattern
{
    internal class Observer : IObserver
    {
        public string UserName { get; set; }

        public Observer(string userName, ISubject subject)
        {
            UserName = userName;
            subject.RegisterObserver(this);
        }

        public void Update(string availability)
        {
            Console.WriteLine(@"Hello {0}, Product is now {1} on Amazon", UserName, availability);
        }
    }
}