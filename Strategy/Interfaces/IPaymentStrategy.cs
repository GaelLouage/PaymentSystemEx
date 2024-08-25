namespace PaymentSystemEx.Strategy.Interfaces
{
    public interface IPaymentStrategy
    {
        string Pay(decimal amount);
    }
}
