namespace R4_PaymentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPaymentSystem first = new FirstPaymentSystem(new MD5HashSystem(), "//pay.system1.ru/order?");
            IPaymentSystem second = new SecondPaymentSystem(new MD5HashSystem(), "//order.system2.ru/pay?");
            IPaymentSystem third = new ThirdPaymentSystem(new SHA1HashSystem(), "//system3.com/pay?", "secret key");
        }
    }
}
