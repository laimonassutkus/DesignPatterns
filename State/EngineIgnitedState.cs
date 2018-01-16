using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class EngineIgnitedState : CarState
    {
        public EngineIgnitedState(CarContext context) : base(context)
        {
        }

        public override void Drive()
        {
            Console.WriteLine("LETS GOOOO");
        }

        public override void IgniteEngine()
        {
            Console.WriteLine("Cant ignite engine twice you moron");
        }
    }
}
