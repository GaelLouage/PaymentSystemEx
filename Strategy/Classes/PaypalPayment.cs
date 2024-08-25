using PaymentSystemEx.Strategy.Interfaces;

namespace PaymentSystemEx.Strategy.Classes
{
    public class PaypalPayment : IPaymentStrategy
    {
        public string Pay(decimal amount)
        {
            // implement bank transfer method
            return $"Processing PayPal payment of {amount:C}";
        }
    }
}
