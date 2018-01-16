using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    interface ISubjectPublisher
    {
        void Register(IObserverSubscriber o);
        void Unregister(IObserverSubscriber o);
        void NotifyObserverSubscriber();
    }

    class Subject : ISubjectPublisher
    {
        private List<IObserverSubscriber> _observers;
        private double a, b, c;

        public Subject()
        {
            _observers = new List<IObserverSubscriber>();
        }

        public void Register(IObserverSubscriber o)
        {
            _observers.Add(o);
        }

        public void Unregister(IObserverSubscriber o)
        {
            _observers.Remove(o);
        }

        public void NotifyObserverSubscriber()
        {
            ChangeValues();

            // Now notify all observers that values have changed
            foreach (var observerSubscriber in _observers)
            {
                observerSubscriber.Update(a, b, c);
            }
        }

        public void ChangeValues()
        {
            // Values have changed
            a = 5;
            b = 5;
            c = 0;
        }
    }
}
