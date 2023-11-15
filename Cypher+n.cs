using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Crypto
{
    public class Cypher_n
    {
        public string Encrypt(string text, int shift)
        {
            Dictionary<char, char> chars = Corespond(shift);

            char[] encryptedChars = new char[text.Length];

            for(int i = 0; i < text.Length; i++)
            {
                char original = text[i];
                char encryptedChar;

                if(chars.TryGetValue(original, out encryptedChar))
                {
                    encryptedChars[i] = encryptedChar;
                }
                else
                {
                    encryptedChars[i] = original;
                }
            }

            return new string(encryptedChars);
        }

        public string Decrypt(string text, int shift)
        {
            return Encrypt(text, -shift);
        }

        public void Cryptoanalisis(string text)
        {
            for(int i = 0; i < 26; i++)
            {
                string decrypted = Decrypt(text, i);

                Console.WriteLine($"Shift by {i}: {decrypted}");
            }
        }

        public Dictionary<char, char> Corespond(int shift)
        {
            Dictionary<char, char> chars = new Dictionary<char, char>();

            for(char c = 'A'; c <= 'Z'; c++)
            {
                char encryptedChar = (char)(((c - 'A' + shift + 26) % 26) + 'A');
                chars[c] = encryptedChar;
            }

            for(char c = 'a'; c <= 'z'; c++)
            {
                char encryptedChar = (char)(((c - 'a' + shift + 26) % 26) + 'a');
                chars[c] = encryptedChar;
            }

            return chars;
        }
    }
}
