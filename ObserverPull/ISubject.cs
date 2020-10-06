using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPush
{
    public class SubjectData
    {
        public int Measurement { get; set; }
    }

    public interface ISubject
    {
        void Attach(IObserver obs);
        void Detach(IObserver obs);
        void Notify();

        SubjectData GetState();
    }
}
