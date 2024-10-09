namespace R4_PaymentSystem
{
    internal class FirstPaymentSystem : IPaymentSystem
    {
        private IHashSystem _hashSystem;

        public FirstPaymentSystem(IHashSystem hashSystem, string paymentSystemLink, string currency = "RUB")
        {
            _hashSystem = hashSystem;
            PaymentSystemLink = paymentSystemLink;
            Currency = currency;
        }

        public string Currency { get; private set; }
        public string PaymentSystemLink { get; private set; }

        public virtual string GetPayingLink(Order order)
        {
            return PaymentSystemLink + StringConstants.AmountString + order.Amount.ToString()
                + Currency + StringConstants.ConcatenationString + StringConstants.HashString
                + _hashSystem.GetHashString(order.Id.ToString());
        }
    }
}
