using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ClassProxy proxy = new ClassProxy();
            proxy.ShowName();
        }
    }
}
