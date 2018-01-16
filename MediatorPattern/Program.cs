using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            IMediator planeMediator = new MediatorPlaneStation();

            IPlane jet1 = new Jet(planeMediator);
            IPlane jet2 = new Jet(planeMediator);
            IPlane boeing1 = new Boeing(planeMediator);

            jet1.Land();
            jet2.TakeOff();

            planeMediator.FreeWay();
            planeMediator.FreeWay();
            planeMediator.FreeWay();

            boeing1.Land();
            boeing1.Land();
        }
    }
}
