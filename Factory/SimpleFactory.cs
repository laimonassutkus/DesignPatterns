using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class SimpleFactory
    {
        private SimpleFactory(object a, object b, object c)
        {
            
        }

        public static SimpleFactory Create(object a, object b, object c)
        {
            return new SimpleFactory(a, b, c);
        }
    }
}
