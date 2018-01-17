using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    interface IAircraftFactory
    {
        IAircraft MakeFastAndExpensive();
        IAircraft MakeSlowAndCheap();
    }
}
