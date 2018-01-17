using System;
using System.Collections.Generic;
using System.Text;
using Builder.Phone_parts;

namespace Builder
{
    class Phone : IPhone
    {
        public Phone()
        {

        }

        public GPU Gpu { private get; set; }
        public CPU Cpu { private get; set; }
        public RAM Ram { private get; set; }
        public Screen Screen { private get; set; }

        public CPU GetCpu()
        {
            return Cpu;
        }

        public GPU GetGpu()
        {
            return Gpu;
        }

        public RAM GetRam()
        {
            return Ram;
        }

        public Screen GetScreen()
        {
            return Screen;
        }
    }
}
