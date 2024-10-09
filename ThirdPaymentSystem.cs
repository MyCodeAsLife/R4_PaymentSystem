namespace R4_PaymentSystem
{
    internal class ThirdPaymentSystem: IPaymentSystem
    {
        private IHashSystem _hashSystem;
        private string _seecretKey;

        public ThirdPaymentSystem(IHashSystem hashSystem, string paymentSystemLink, string seecretKey, string currency = "RUB")
        {
            _seecretKey = seecretKey;
            _hashSystem = hashSystem;
            PaymentSystemLink = paymentSystemLink;
            Currency = currency;
        }

        public string Currency { get; private set; }
        public string PaymentSystemLink { get; private set; }

        public string GetPayingLink(Order order)
        {
            string stringToHash = order.Amount.ToString() + order.Id.ToString() + _seecretKey;
            return PaymentSystemLink + StringConstants.AmountString + order.Amount.ToString()
                + StringConstants.ConcatenationString + StringConstants.CurrencyString + Currency
                + StringConstants.ConcatenationString + _hashSystem.GetHashString(stringToHash);
        }
    }
}
