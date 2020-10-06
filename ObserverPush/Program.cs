using System;

namespace ObserverPush
{
    class Program
    {
        static void Main()
        {
            ConcreteSubject subject = new ConcreteSubject();

            IObserver observer = new ConcreteObserver(subject);

            subject.ChangeSubjectValue(50);
        }
    }
}
