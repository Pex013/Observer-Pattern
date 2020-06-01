namespace ObserverPattern.Interfaces
{
    internal interface ISubject
    {
        void RegisterObserver(IObserver observer);

        void NotifyObservers();
    }
}