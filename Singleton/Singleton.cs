using System;

namespace Singleton
{
    public sealed class Singleton
    {

        private static Singleton _instance = null;
        private static int counter = 0;
        private static readonly object _instanceLock = new object();
        private Singleton()
        {
            counter++;
            Console.WriteLine($"Count Constructor call:{counter}");
        }

        public static Singleton getSingleInstance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_instanceLock)
                    {
                        if (_instance == null)
                            _instance = new Singleton();
                        
                    }
                }
                return _instance;
            }
        }

        public void PrintDetails(string str)
        {
            Console.WriteLine(str);
        }


    }
}
