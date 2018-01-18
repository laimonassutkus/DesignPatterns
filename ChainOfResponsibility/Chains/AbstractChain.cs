using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Chains
{
    abstract class AbstractChain
    {
        protected AbstractChain nextChain;

        public void SetNextChaing(AbstractChain chain)
        {
            nextChain = chain;
        }

        public abstract void Parse(string number);
    }
}
