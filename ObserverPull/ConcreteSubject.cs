using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPush
{
    public class ConcreteSubject : ISubject
    {
        private SubjectData currentValue = new SubjectData();

        public SubjectData GetState()
        {
            return currentValue;
        }
        public void ChangeSubjectValue(int newMeasurement)
        {
            currentValue.Measurement = newMeasurement;
            Notify();
        }

    }
}
