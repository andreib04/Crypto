using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaesarCypher caesar = new CaesarCypher();

            string txt = "HELLO";
            //string encrypted = caesar.Encrypt(txt, 3);

            //Console.WriteLine(encrypted);
            //Console.WriteLine(caesar.Decrypt(encrypted, 3));

            Cypher_n cypher = new Cypher_n();

            string encrypt = cypher.Encrypt(txt, 5);

            Console.WriteLine(encrypt);
            Console.WriteLine(cypher.Decrypt(encrypt, 5));
            cypher.Cryptoanalisis(encrypt);
        }
    }
}
