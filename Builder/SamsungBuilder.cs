using Builder.Phone_parts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class SamsungBuilder : IPhoneBuilder
    {
        Phone phoneToBuild;

        public SamsungBuilder()
        {
            phoneToBuild = new Phone();
        }

        public void BuildCpu()
        {
            phoneToBuild.Cpu = new CPU("Ludicrous SnapDragon CPU");
        }

        public void BuildGpu()
        {
            phoneToBuild.Gpu = new GPU("Ludicrous Adreno GPU");
        }

        public void BuildRam()
        {
            phoneToBuild.Ram = new RAM("Ludicrous 8GB of RAM");
        }

        public void BuildScreen()
        {
            phoneToBuild.Screen = new Screen("Beautiful giant screen");
        }

        public IPhone GetPhone()
        {
            var builtPhone = phoneToBuild;

            // Reset current phone
            phoneToBuild = null;

            return builtPhone;
        }
    }
}
