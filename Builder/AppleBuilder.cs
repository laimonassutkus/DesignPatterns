using Builder.Phone_parts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class AppleBuilder : IPhoneBuilder
    {
        Phone phoneToBuild;

        public AppleBuilder()
        {
            phoneToBuild = new Phone();
        }

        public void BuildCpu()
        {
            phoneToBuild.Cpu = new CPU("Good SnapDragon CPU");
        }

        public void BuildGpu()
        {
            phoneToBuild.Gpu = new GPU("Decent Adreno GPU");
        }

        public void BuildRam()
        {
            phoneToBuild.Ram = new RAM("Shitty 2GB of RAM");
        }

        public void BuildScreen()
        {
            phoneToBuild.Screen = new Screen("Beautiful screen");
        }

        public IPhone GetPhone()
        {
            // Reset current phone
            phoneToBuild = null;

            return phoneToBuild;
        }
    }
}
