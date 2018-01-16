using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class Flyweight
    {
        public IntrinsicState IState { get; set; }
        public ExtrinsicState EState { get; set; }

        public Flyweight()
        {

        }
    }
}
