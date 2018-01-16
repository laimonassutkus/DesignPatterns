using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    abstract class CarState : ICarState
    {
        protected readonly CarContext context;

        public CarState(CarContext context)
        {
            this.context = context;
        }

        public abstract void Drive();
        public abstract void IgniteEngine();
    }
}
