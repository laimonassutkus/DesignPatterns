using Builder.Phone_parts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    interface IPhone
    {
        GPU GetGpu();
        CPU GetCpu();
        RAM GetRam();
        Screen GetScreen();
    }
}
