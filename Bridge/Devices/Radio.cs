using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class Radio : AbstractDevice
    {
        public override void arrowLeftPress()
        {
            Console.WriteLine("Radio frequency down.");
        }

        public override void arrowRightPress()
        {
            Console.WriteLine("Radio frequency up.");
        }
    }
}
