using PaymentSystemEx.Strategy.Interfaces;

namespace PaymentSystemEx.Strategy.Classes
{
    public class BankTransferPayment : IPaymentStrategy
    {
        public string Pay(decimal amount)
        {
            // implement bank transfer method
            return $"Processing BankTransfer payment of {amount:C}";

        }
    }
}
