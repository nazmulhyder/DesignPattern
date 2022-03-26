using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    interface  ICreditCard
    {
        string CardType();
        int CreditCardLimit();
        int GetAnnualChage();

    }
}
