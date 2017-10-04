using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    /// <summary>
    /// Thread safe fast singleton
    /// </summary>
    class LazySingleton
    {
        private LazySingleton()
        {

        }

        public static LazySingleton Instance => Nested.NInstance;

        private class Nested
        {
            /// <summary>
            /// Ensure lazyness
            /// </summary>
            static Nested()
            {
                
            }

            internal static readonly LazySingleton NInstance = new LazySingleton();
        }
    }
}
