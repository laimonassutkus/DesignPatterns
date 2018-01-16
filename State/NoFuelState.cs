using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class NoFuelState : CarState
    {
        public NoFuelState(CarContext context) : base(context)
        {
        }

        public override void Drive()
        {
            Console.WriteLine("Need fuel");
        }

        public override void IgniteEngine()
        {
            Console.WriteLine("Cant ignite. Need fuel");
        }
    }
}
