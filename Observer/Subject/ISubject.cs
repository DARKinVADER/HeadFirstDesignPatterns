using Observer.Observers;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Subject
{
    public interface ISubject
    {
        public void RegisterObserver(IObserver observer);
        public void UnregisterObserver(IObserver observer);
        public void NotifyObservers();

    }
}
