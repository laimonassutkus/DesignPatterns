using Facade.StuffUnderTheHood;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class Facade
    {
        C c;
        A a;
        B b;

        public Facade()
        {
            c = new C();
            a = new A(c);
            b = new B(c, a);

            c.SetDependency(a);
        }

        public void DoSomeStuff()
        {
            b.Stuff();
        }

        public void DoSomeOtherStuff()
        {
            c.Dependecy.StuffToSay("Random stuff", b);
        }
    }
}
