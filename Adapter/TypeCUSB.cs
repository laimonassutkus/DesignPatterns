using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class TypeCUSBMale : IUsbTypeCActions
    {
        public void PutInUsbTypeC()
        {
            Console.WriteLine("Puting in a USB type C");
        }

        public void PutOutUsbTypeC()
        {
            Console.WriteLine("Puting out a USB type C");
        }
    }
}
