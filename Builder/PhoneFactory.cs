using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class PhoneFactory
    {
        IPhoneBuilder appleBuilder;
        IPhoneBuilder samsungBuilder;

        public PhoneFactory()
        {
            appleBuilder = new AppleBuilder();
            samsungBuilder = new SamsungBuilder();
        }

        public IPhone GetExpensiveAndShittyPhone()
        {
            appleBuilder.BuildCpu();
            appleBuilder.BuildGpu();
            appleBuilder.BuildRam();
            appleBuilder.BuildScreen();

            return appleBuilder.GetPhone();
        }

        public IPhone GetGoodAndRelaiblePhone()
        {
            samsungBuilder.BuildCpu();
            samsungBuilder.BuildGpu();
            samsungBuilder.BuildRam();
            samsungBuilder.BuildScreen();

            return samsungBuilder.GetPhone();
        }
    }
}
