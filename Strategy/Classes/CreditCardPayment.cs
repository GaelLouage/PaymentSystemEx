using PaymentSystemEx.Strategy.Interfaces;

namespace PaymentSystemEx.Strategy.Classes
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public string Pay(decimal amount)
        {
            // implement bank transfer method

            return $"Processing CreditCard payment of {amount:C}";
        }
    }
}
