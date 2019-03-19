using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneTimePad
{
    public class Encryptor : IEncrypt
    {
        Random _random;
        String _key;

        public Encryptor()
        {
            _random = new Random();
            _key = String.Empty;
        }

        public byte[] decrypt(byte[] toDecrypt)
        {
            byte[] key = Encoding.Default.GetBytes(_key);

            for (int i = 0; i < toDecrypt.Length; i++)
            {
                toDecrypt[i] ^= key[i];
            }

            return toDecrypt;
        }

        public byte[] encrypt(byte[] toEncrypt)
        {
            byte[] key = Encoding.Default.GetBytes(_key);

            for (int i = 0; i<toEncrypt.Length; i++)
            {
                toEncrypt[i] ^= key[i];
            }

            return toEncrypt;
        }

        public String generateOneTimePadKey(int keyLength)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for(int i = 0; i < keyLength; i++)
            {
                stringBuilder.Append((char)(_random.Next(26)+65));
            }

            _key = stringBuilder.ToString();

            return stringBuilder.ToString();
        }

        public string getUtf8String(string toConvert)
        {
            byte[] bytes = Encoding.Default.GetBytes(toConvert);
            toConvert = Encoding.UTF8.GetString(bytes);
            return toConvert;
        }
    }
}
