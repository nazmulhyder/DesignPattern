using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class WhySealedClass
    {
        private static WhySealedClass _instance = null;
        private static int counter = 0;
        private WhySealedClass()
        {
            counter++;
            Console.WriteLine($"Count Constructor call:{counter}");
        }

        public static WhySealedClass getSingleInstance
        {
            get
            {
                if (_instance == null)
                    _instance = new WhySealedClass();
                return _instance;
            }
        }

        public void PrintDetails(string str)
        {
            Console.WriteLine(str);
        }

        public class DerivedSingleton : WhySealedClass
        {

        }

    }
}
