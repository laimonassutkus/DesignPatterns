using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.StuffUnderTheHood
{
    class B
    {
        private readonly C c;
        private readonly A a;

        public B(C c , A a)
        {
            this.c = c;
            this.a = a;
        }

        public void Stuff()
        {
            Console.WriteLine("Class B stuff");
        }
    }
}
