using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Phone_parts
{
    class RAM
    {
        public RAM(string type)
        {
            Type = type;
        }

        public string Type { get; }
    }
}
