using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto
{
    public class CaesarCypher
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

        public  string Decrypt(string text, int shift)
        {
            return Encrypt(text, -shift);
        }

        public Dictionary<char, char> Corespond(int shift)
        {
            Dictionary<char, char> chars = new Dictionary<char, char>();

            for(char c = 'A'; c <= 'Z'; c++)
            {
                char encryptedChar = (char)(((c - 'A' + 3 + 26) % 26) + 'A');
                chars[c] = encryptedChar;
            }

            for(char c = 'a'; c <= 'z'; c++)
            {
                char encryptedChar = (char)(((c - 'a' + 3 + 26) % 26) + 'a');  
                chars[c] = encryptedChar;
            }

            return chars;
        }
    }
}
