using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
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
