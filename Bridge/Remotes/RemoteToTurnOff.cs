using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Remotes
{
    class RemoteToTurnOff : AbstractRemote
    {
        public RemoteToTurnOff(AbstractDevice abstractDevice) : base(abstractDevice)
        {
        }

        public override void EnterPress()
        {
            abstractDevice.TurnOffTheDevice();
        }
    }
}
