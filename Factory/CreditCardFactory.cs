using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard creditCard = null;
            if(cardType == "Money Back")
            {
                creditCard =  new MoneyBack();
            }
            if (cardType == "Platinium")
            {
                creditCard = new Platinum();
            }
            if (cardType == "Titanium")
            {
                creditCard = new Titanium();
            }

            return creditCard;
        }
    }
}
