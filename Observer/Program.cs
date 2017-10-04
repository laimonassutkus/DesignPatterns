using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubjectPublisher publisher = new Subject();

            IObserverSubscriber subscriber1 = new Observer(publisher);
            IObserverSubscriber subscriber2 = new Observer(publisher);

            publisher.NotifyObserverSubscriber();
        }
    }
}
