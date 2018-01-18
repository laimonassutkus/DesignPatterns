using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.StuffUnderTheHood
{
    class C
    {
        public A Dependecy { get; set; }

        public void SetDependency(A a)
        {
            Dependecy = a;
        }
    }
}
