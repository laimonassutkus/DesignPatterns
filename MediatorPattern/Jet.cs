using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    class Jet : IPlane
    {
        private readonly IMediator mediatorPlaneStation;

        public Jet(IMediator mediatorPlaneStation)
        {
            this.mediatorPlaneStation = mediatorPlaneStation;
        }

        public void Land()
        {
            mediatorPlaneStation.Land(this);
        }

        public void TakeOff()
        {
            mediatorPlaneStation.TakeOff(this);
        }
    }
}
