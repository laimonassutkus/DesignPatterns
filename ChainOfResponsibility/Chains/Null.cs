using System;

namespace ChainOfResponsibility.Chains
{
    class Null : AbstractChain
    {
        public override void Parse(string number)
        {
            Console.WriteLine("Can't parse");
        }
    }
}
