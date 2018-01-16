using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class EngineOffState : CarState
    {
        public EngineOffState(CarContext context) : base(context)
        {
        }

        public override void Drive()
        {
            Console.WriteLine("Ignite the engine first.");
        }

        public override void IgniteEngine()
        {
            Console.WriteLine("Wruuum!");
            context.SetState(context.EngineIgnited);
        }
    }
}
