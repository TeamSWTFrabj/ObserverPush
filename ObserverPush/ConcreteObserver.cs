using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPush
{
    public class ConcreteObserver : IObserver
    {
        private ISubject mySubject;

        public ConcreteObserver(ISubject subject)
        {
            mySubject = subject;
            mySubject.Attach(this);
        }

        public void Update(SubjectData subjectData)
        {
            // Handle new value of subject data
            Console.WriteLine($"Received new subject value: {subjectData.Measurement}");
        }
    }
}
