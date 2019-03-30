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

        /// <summary>
        /// Metoda deszyfrująca daną parametrem tablicę bajtów korzystając z zapisanego w pamięci klucza
        /// </summary>
        /// <param name="toDecrypt">tablica bajtów z danymi do odszyfrowania</param>
        /// <returns>odszyfrowane dane</returns>
        public byte[] decrypt(byte[] toDecrypt)
        {
            //zamiana klucza na tablicę bajtów
            byte[] key = Encoding.Default.GetBytes(_key);

            //deszyfrowanie (XOR tablicy zaszyfrowanych danych z tablicą klucza)
            for (int i = 0; i < toDecrypt.Length; i++)
            {
                toDecrypt[i] ^= key[i];
            }

            return toDecrypt;
        }

        /// <summary>
        /// Metoda szyfrująca daną parametrem tablicę bajtów
        /// </summary>
        /// <param name="toEncrypt">tablica bajtów z danymi do zaszyfrowania</param>
        /// <returns>zaszyfrowane dane</returns>
        public byte[] encrypt(byte[] toEncrypt)
        {
            //zamiana klucza na tablicę bajtów
            byte[] key = Encoding.Default.GetBytes(_key);

            //szyfrowanie (XOR tablicy danych z tablicą klucza)
            for (int i = 0; i<toEncrypt.Length; i++)
            {
                toEncrypt[i] ^= key[i];
            }

            return toEncrypt;
        }

        /// <summary>
        /// Metoda generująca losowy klucz szyfrujący
        /// </summary>
        /// <param name="keyLength">długość klucza, powinna być nie mniejsza niż długoś tablicy z danymi do zaszyfrowania</param>
        /// <returns>klucz do szyfrowania</returns>
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

        /// <summary>
        /// Metoda zwracająca łańcuch znaków zakodowany w UTF8
        /// </summary>
        /// <param name="toConvert">łańcuch znaków do zakodowania</param>
        /// <returns>łańcuch znaków po kodowaniu</returns>
        public string getUtf8String(string toConvert)
        {
            byte[] bytes = Encoding.Default.GetBytes(toConvert);
            toConvert = Encoding.UTF8.GetString(bytes);
            return toConvert;
        }
    }
}
