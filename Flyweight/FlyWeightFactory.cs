using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class FlyWeightFactory
    {
        private static Dictionary<IntrinsicState, Flyweight> states = new Dictionary<IntrinsicState, Flyweight>();

        public static Flyweight GetFlyweight(IntrinsicState state)
        {
            if (!states.ContainsKey(state))
                states.Add(state, new Flyweight());

            return states[state];
        }
    }
}
