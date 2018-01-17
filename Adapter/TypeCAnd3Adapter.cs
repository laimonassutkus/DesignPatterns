using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class TypeCAnd3Adapter : IUsbTypeCActions
    {
        private readonly Type3USB type3USB;

        public TypeCAnd3Adapter(Type3USB type3USB)
        {
            this.type3USB = type3USB;
        }

        public void PutInUsbTypeC()
        {
            Console.WriteLine("Applying the adapter");
            type3USB.PutInUsbType3();
        }

        public void PutOutUsbTypeC()
        {
            Console.WriteLine("Applying the adapter");
            type3USB.PutOutUsbType3();
        }
    }
}
