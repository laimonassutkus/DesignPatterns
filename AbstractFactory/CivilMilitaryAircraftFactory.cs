using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    class CivilMilitaryAircraftFactory : IAircraftFactory
    {
        public IAircraft MakeFastAndExpensive()
        {
            return new MilitaryAircraft();
        }

        public IAircraft MakeSlowAndCheap()
        {
            return new CivilAircraft();
        }
    }
}
