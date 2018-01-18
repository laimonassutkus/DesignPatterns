using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.Remotes
{
    abstract class AbstractRemote : IDifferentActions
    {
        protected readonly AbstractDevice abstractDevice;

        public AbstractRemote(AbstractDevice abstractDevice)
        {
            this.abstractDevice = abstractDevice;
        }

        public void arrowLeftPress()
        {
            abstractDevice.arrowLeftPress();
        }

        public void arrowRightPress()
        {
            abstractDevice.arrowRightPress();
        }

        public abstract void EnterPress();  
    }
}
