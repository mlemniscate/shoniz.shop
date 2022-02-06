namespace shoniz.Framework.Core
{
    public interface IHashProvider
    {
        string Hash(string plainText, string saltedValue);
    }
}
