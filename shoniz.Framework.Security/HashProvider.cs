using shoniz.Framework.Core;

namespace shoniz.Framework.Security
{
    public class HashProvider : IHashProvider
    {
        public string Hash(string plainText, string saltedValue)
        {
            /*System.Security.Cryptography.HashAlgorithm();*/
            return plainText;
        }
    }
}
