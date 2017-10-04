using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Strategy
{
    class Strategy
    {
        public void DoMethod(List<int> a, IMethod method)
        {
            method.Do(a);
        }
    }

    interface IMethod
    {
        void Do(List<int> a);
    }

    class MethodA : IMethod
    {
        public void Do(List<int> a)
        {
        }
    }

    class MethodB : IMethod
    {
        public void Do(List<int> a)
        {
        }
    }
}
