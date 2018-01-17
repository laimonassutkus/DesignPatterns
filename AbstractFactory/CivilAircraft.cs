using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class CivilAircraft : IAircraft
    {
        public float GetMaxSpeed()
        {
            return 300;
        }

        public float GetPrice()
        {
            return 50000;
        }
    }
}
