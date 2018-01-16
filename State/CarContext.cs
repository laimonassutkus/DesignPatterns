using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    class CarContext : ICarState 
    {
        public CarState EngineIgnited;
        public CarState EngineOff;
        public CarState NoFuel;

        CarState currentState;

        public CarContext()
        {
            EngineIgnited = new EngineIgnitedState(this);
            EngineOff = new EngineOffState(this);
            NoFuel = new NoFuelState(this);

            currentState = EngineOff;
        }

        public void SetState(CarState state)
        {
            currentState = state;
        }

        public void IgniteEngine()
        {
            currentState.IgniteEngine();
        }

        public void Drive()
        {
            currentState.Drive();
        }
    }
}
