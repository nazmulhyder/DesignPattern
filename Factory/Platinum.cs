using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class Platinum : ICreditCard
    {
        public string CardType()
        {
            return "Platinum";
        }

        public int CreditCardLimit()
        {
            return 35000;
        }

        public int GetAnnualChage()
        {
            return 2000;
        }
    }
}
