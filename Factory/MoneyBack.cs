using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class MoneyBack : ICreditCard
    {
        public string CardType()
        {
            return "Money Back";
        }

        public int CreditCardLimit()
        {
            return 15000;
        }

        public int GetAnnualChage()
        {
            return 500;
        }
    }
}
