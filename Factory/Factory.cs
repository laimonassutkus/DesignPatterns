using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class ObjFactory
    {
        public static Obj LoadObj()
        {
            int val = 2;
            switch (val)
            {
                case 1:
                    return new Obj(new object(), new object());

                case 2:
                    int a = 5;
                    return new Obj(a, new object());
                default:
                    return new Obj(1, 2);
            }
        }
    }

    class Obj
    {
        internal Obj(object a, object b)
        {
            
        }
    }
}
