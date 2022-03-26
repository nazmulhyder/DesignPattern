using System;

namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICreditCard creditCard = CreditCardFactory.GetCreditCard("Platinum");

            if (creditCard == null)
            {
                Console.WriteLine($"Card Type: {creditCard.CardType()}");
                Console.WriteLine($"Card Limit: {creditCard.CreditCardLimit()}");
                Console.WriteLine($"Card Annual Charge: {creditCard.GetAnnualChage()}");
            }

            else
            {
                Console.WriteLine("Invalid Card Type");
            }
        }
    }
}
