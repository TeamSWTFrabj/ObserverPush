﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPush
{
    public class ConcreteSubject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private SubjectData currentValue = new SubjectData();

        public void Attach(IObserver obs)
        {
            observers.Add(obs);
        }

        public void Detach(IObserver obs)
        {
            // Be careful using Remove, Equals or operator== must be implemented
            observers.Remove(obs);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(currentValue);
            }    
        }

        public void ChangeSubjectValue(int newMeasurement)
        {
            currentValue.Measurement = newMeasurement;
            Notify();
        }


    }
}
