using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    interface ICarState
    {
        void IgniteEngine();
        void Drive();
    }
}
