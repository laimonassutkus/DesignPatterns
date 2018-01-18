using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Remotes
{
    class RemoteToMute : AbstractRemote
    {
        public RemoteToMute(AbstractDevice abstractDevice) : base(abstractDevice)
        {
        }

        public override void EnterPress()
        {
            abstractDevice.SetVolume(0);
            Console.WriteLine("The device was muted.");
        }
    }
}
