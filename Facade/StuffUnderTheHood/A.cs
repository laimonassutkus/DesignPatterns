using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.StuffUnderTheHood
{
    class A
    {
        private readonly C c;

        public A(C c)
        {
            this.c = c;
        }

        public void StuffToSay(string stuff, B b)
        {
            Console.WriteLine($"Stuff from A: {stuff}. And here it comes from B:");
            b.Stuff();
        }
    }
}
