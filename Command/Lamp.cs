using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    class Lamp : IReceiverDevice
    {
        public void Off()
        {
            Console.WriteLine("The light is off");
        }

        public void On()
        {
            Console.WriteLine("The light is on");
        }
    }
}
