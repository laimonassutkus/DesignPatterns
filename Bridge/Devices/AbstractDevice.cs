using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    abstract class AbstractDevice : IDifferentActions
    {
        protected int volume = 0;
        protected int channel = 0;

        public void TurnOffTheDevice()
        {
            Console.WriteLine("Its turned off.");
        }

        public void SetVolume(int volume)
        {
            this.volume = volume;
        }

        public virtual void arrowUpPress()
        {
            Console.WriteLine($"Volume increased. Now it is {++volume}.");
        }

        public virtual void arrowDownPress()
        {
            Console.WriteLine($"Volume decreased. Now it is {--volume}.");
        }

        public abstract void arrowLeftPress();
        public abstract void arrowRightPress();
    }
}
