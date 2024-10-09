namespace R4_PaymentSystem
{
    internal class SecondPaymentSystem : IPaymentSystem
    {
        private IHashSystem _hashSystem;

        public SecondPaymentSystem(IHashSystem hashSystem, string paymentSystemLink, string currency = "RUB")
        {
            _hashSystem = hashSystem;
            PaymentSystemLink = paymentSystemLink;
            Currency = currency;
        }

        public string Currency { get; private set; }
        public string PaymentSystemLink { get; private set; }

        public string GetPayingLink(Order order)
        {
            string stringToHash = order.Id.ToString() + order.Amount.ToString();
            return PaymentSystemLink + StringConstants.HashString + _hashSystem.GetHashString(stringToHash);
        }
    }
}
