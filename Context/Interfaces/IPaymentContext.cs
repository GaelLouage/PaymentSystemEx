using PaymentSystemEx.Strategy.Interfaces;

namespace PaymentSystemEx.Context.Interfaces
{
    public interface IPaymentContext
    {
        string Payment(IPaymentStrategy paymentStrategy, decimal amount);
    }
}