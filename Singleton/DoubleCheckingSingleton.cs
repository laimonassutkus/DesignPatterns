using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class DoubleCheckingSingleton
    {
        private static object _lock = new object();
        private static DoubleCheckingSingleton _instance;

        private DoubleCheckingSingleton()
        {
            
        }

        public static DoubleCheckingSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DoubleCheckingSingleton();
                        }
                    } 
                }
                return _instance;
            }
        }
    }
}
