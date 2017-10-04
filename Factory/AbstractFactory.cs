using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Text;

namespace Factory
{
    class MonsterFactory
    {
        public static IMonster GetMonster(int a)
        {
            switch (a)
            {
                case 1:
                    return new LandMonster();
                default:
                    return new SeaMonster();
            }
        }
    }

    interface IMonster
    {
        
    }

    class LandMonster : IMonster
    {
        
    }

    class SeaMonster : IMonster
    {
        
    }
}
