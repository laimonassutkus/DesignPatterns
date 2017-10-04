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
            foreach (var observerSubscriber in _observers)
            {
                observerSubscriber.Update(a, b, c);
            }
        }

        public void ChangeValues()
        {
            a = 5;
            b = 5;
            c = 0;

            NotifyObserverSubscriber();
        }
    }

    interface IObserverSubscriber
    {
        void Update(double a, double b, double c);
    }

    class Observer : IObserverSubscriber
    {
        private double x, y, z;

        private static int observerIdTracker = 0;
        private int observerID;
        private ISubjectPublisher subject;

        public Observer(ISubjectPublisher subject)
        {
            this.subject = subject;
            observerID = ++observerIdTracker;

            this.subject.Register(this);
        }

        public void Update(double a, double b, double c)
        {
            x = a;
            y = b;
            z = c;

            Console.WriteLine("I got my values updated!");
        }
    }
}
