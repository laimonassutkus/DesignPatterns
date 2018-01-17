using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    interface IPhoneBuilder
    {
        void BuildRam();
        void BuildCpu();
        void BuildGpu();
        void BuildScreen();

        IPhone GetPhone();
    }
}
