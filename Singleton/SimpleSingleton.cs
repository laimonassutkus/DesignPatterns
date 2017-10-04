using System;

namespace Singleton
{
    /// <summary>
    /// This is not thread safe singleton 
    /// </summary>
    class SimpleSingleton
    {
        private static SimpleSingleton _instance;

        private SimpleSingleton()
        {
            
        }

        public static SimpleSingleton Instance => _instance ?? (_instance = new SimpleSingleton());
    }
}
