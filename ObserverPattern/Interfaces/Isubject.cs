namespace ObserverPattern.Interfaces
{
    internal interface ISubject
    {
        void RegisterObserver(IObserver observer);

        void RemoveObserver(IObserver observer);

        void AddObserver(IObserver observer);

        void NotifyObservers();
    }
}