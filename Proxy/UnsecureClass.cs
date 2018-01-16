using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class UnsecureClass : ISecureData
    {
        internal string name = "Name";
        internal string date = "2018";

        internal string secret = "Secret";

        public void ShowDate()
        {
            Console.WriteLine(date);
        }

        public void ShowName()
        {
            Console.WriteLine(name);
        }
    }
}
