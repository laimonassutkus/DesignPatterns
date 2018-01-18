using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class TV : AbstractDevice
    {
        public override void arrowLeftPress()
        {
            Console.WriteLine("Previous channel.");
        }

        public override void arrowRightPress()
        {
            Console.WriteLine("Next channel.");
        }
    }
}
