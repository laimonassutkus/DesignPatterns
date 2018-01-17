using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Type3USB
    {
        public void PutInUsbType3()
        {
            Console.WriteLine("Puting in a USB type 3.0");
        }

        public void PutOutUsbType3()
        {
            Console.WriteLine("Puting out a USB type 3.0");
        }
    }
}
