namespace R4_PaymentSystem
{
    public interface IPaymentSystem
    {
        public string PaymentSystemLink { get; }
        public string Currency { get; }

        string GetPayingLink(Order order);
    }
}
