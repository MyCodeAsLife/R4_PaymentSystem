using System.Security.Cryptography;
using System.Text;


namespace R4_PaymentSystem
{
    internal class MD5HashSystem : IHashSystem
    {
        public string GetHashString(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            byte[] hashMD5 = md5.ComputeHash(bytes);
            return Encoding.UTF8.GetString(hashMD5);
        }
    }
}
