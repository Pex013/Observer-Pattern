namespace ObserverPattern.Interfaces
{
    public interface IObserver
    {
        string UserName { get; }

        void Update(string availability);
    }
}