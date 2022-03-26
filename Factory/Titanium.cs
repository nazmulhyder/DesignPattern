using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Titanium : ICreditCard
    {
        public string CardType()
        {
            return "Titanium";
        }

        public int CreditCardLimit()
        {
            return 25000;
        }

        public int GetAnnualChage()
        {
            return 15000;
        }
    }
}
