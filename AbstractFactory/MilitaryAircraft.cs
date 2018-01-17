using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class MilitaryAircraft : IAircraft
    {
        public float GetMaxSpeed()
        {
            return 600;
        }

        public float GetPrice()
        {
            return 100000;
        }
    }
}
