using Observer.Subject;

namespace Observer.Observers
{
    public interface IObserver
    {
        public void Update(State state);
    }
}