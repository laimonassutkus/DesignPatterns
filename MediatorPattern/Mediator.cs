using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    class MediatorPlaneStation : IMediator
    {
        private bool isPlaneRoadFree = true;
        private Dictionary<IPlane, PlaneActions> waitingPlains = new Dictionary<IPlane, PlaneActions>();

        private void AddPlane(IPlane plane, PlaneActions action)
        {
            if (isPlaneRoadFree)
            {
                switch (action)
                {
                    case PlaneActions.TAKE_OFF:
                        Console.WriteLine($"{plane.ToString()} is taking off.");
                        break;
                    case PlaneActions.LAND:
                        Console.WriteLine($"{plane.ToString()} is landing.");
                        break;
                    default:
                        break;
                }
                return;
            }

            Console.WriteLine($"Road is not free. The plane {plane.ToString()} has to wait to do its action.");
            waitingPlains.Add(plane, action);
            isPlaneRoadFree = false;
        }

        public void FreeWay()
        {
            try
            {
                var keyValue = waitingPlains.First();
                waitingPlains.Remove(keyValue.Key);

                IPlane plane = keyValue.Key;

                switch (keyValue.Value)
                {
                    case PlaneActions.TAKE_OFF:
                        Console.WriteLine($"{plane.ToString()} is taking off.");
                        break;
                    case PlaneActions.LAND:
                        Console.WriteLine($"{plane.ToString()} is landing.");
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                isPlaneRoadFree = true;
                Console.WriteLine("Road is now free");
                return;
            }
        }

        public void Land(IPlane plane)
        {
            AddPlane(plane, PlaneActions.LAND);
        }

        public void TakeOff(IPlane plane)
        {
            AddPlane(plane, PlaneActions.TAKE_OFF);
        }
    }
}
