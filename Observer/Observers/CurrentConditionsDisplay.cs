using Observer.Subject;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Observers
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private State _state;

        public CurrentConditionsDisplay(ISubject subject)
        {
            subject.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine($"Current temperature is {_state.Temperature}");
        }

        public void Update(State state)
        {
            _state = state;
            Display();
        }
    }
}
