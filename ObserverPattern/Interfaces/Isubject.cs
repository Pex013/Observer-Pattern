namespace ObserverPattern.Interfaces
{
    internal interface ISubject
    {
        string ProductName { get; }
        int ProductPrice { get; }

        void RegisterObserver(IObserver observer);

        void NotifyObservers();
    }
}