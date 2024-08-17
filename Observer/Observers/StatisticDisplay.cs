using Observer.Subject;

namespace Observer.Observers
{
    public class StatisticDisplay : IObserver, IDisplayElement
    {
        State _state;

        public StatisticDisplay(ISubject subject)
        {
            subject.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine($"Statistic is {_state.Pressure}");
        }

        public void Update(State state)
        {
            _state = state;
            Display();
        }
    }
}
