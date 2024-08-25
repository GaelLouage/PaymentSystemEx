using PaymentSystemEx.Context.Interfaces;
using PaymentSystemEx.Strategy.Interfaces;
using System.Diagnostics.Contracts;

namespace PaymentSystemEx.Context.Classes
{
    public class PaymentContext : IPaymentContext
    {
        public string Payment(
            IPaymentStrategy paymentStrategy,
            decimal amount)
        {
            if (amount <= 0)
            {
                return "Invalid Amount! A value bigger than 0 is required.";
            }
            return paymentStrategy.Pay(amount);
        }
    }
}
