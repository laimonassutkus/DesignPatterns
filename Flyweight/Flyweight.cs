using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Flyweight
{
    class Flyweight
    {
        public IntrinsicState IState { get; set; }
        public ExtrinsicState EState { get; set; }

        public Flyweight()
        {
            Thread.Sleep(1);
        }
    }
}
