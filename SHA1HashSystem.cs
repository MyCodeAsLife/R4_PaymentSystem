using System.Security.Cryptography;
using System.Text;

namespace R4_PaymentSystem
{
    internal class SHA1HashSystem : IHashSystem
    {
        public string GetHashString(string input)
        {
            SHA1 sha1 = SHA1.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            byte[] hashSHA1 = sha1.ComputeHash(bytes);
            return Encoding.UTF8.GetString(hashSHA1);
        }
    }
}
