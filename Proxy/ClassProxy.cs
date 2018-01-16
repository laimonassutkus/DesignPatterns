using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class ClassProxy : ISecureData
    {
        public void ShowDate()
        {
            ISecureData c = new UnsecureClass();
            c.ShowDate();
        }

        public void ShowName()
        {
            ISecureData c = new UnsecureClass();
            c.ShowName();
        }
    }
}
