using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CaesarСypherLib;

namespace Tester
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text;

            using(StreamReader sr = new StreamReader(".\\хуй.txt"))
            {
                text = sr.ReadToEnd();
            }

            text = CaesarСypher.Coder(text.ToCharArray(), 3, Language.russian);

            Console.WriteLine(text);


            var key = CaesarСypher.VzlomJopi(text, Language.russian);

            text = CaesarСypher.Decoder(text.ToCharArray(), key, Language.russian);

            Console.WriteLine(text);


            Console.ReadKey();
        }
    }
}
