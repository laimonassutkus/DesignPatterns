using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator 
{
    interface IMediator
    {
        void TakeOff(IPlane plane);
        void Land(IPlane plane);
        void FreeWay();
    }
}
