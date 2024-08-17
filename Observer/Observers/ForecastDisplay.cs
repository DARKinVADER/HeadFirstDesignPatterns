using Observer.Subject;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Observers
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        State _state;

        public ForecastDisplay(ISubject subject)
        {
            subject.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine($"The weather forecast humidity is {_state.Humidity}");
        }

        public void Update(State state)
        {
            _state = state;
            Display();
        }
    }
}
