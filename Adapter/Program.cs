using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("I have a female USB type C port");

            Type3USB type3USB = new Type3USB();
            type3USB.PutInUsbType3();

            Console.WriteLine("And it doesn't fit!!!");

            IUsbTypeCActions typeCAnd3Adapter = new TypeCAnd3Adapter(type3USB);
            typeCAnd3Adapter.PutInUsbTypeC();

            Console.WriteLine("Now it fits!");
        }
    }
}
