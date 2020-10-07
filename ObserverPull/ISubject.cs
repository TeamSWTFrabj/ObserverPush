using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPush
{
    public class SubjectData
    {
        public int Measurement { get; set; }
    }

    public abstract class ISubject
    {
        private List<IObserver> observers = new List<IObserver>();


        public void Attach(IObserver obs)
        {
            observers.Add(obs);
        }

        public void Detach(IObserver obs)
        {
            observers.Remove(obs);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }

    }
}
