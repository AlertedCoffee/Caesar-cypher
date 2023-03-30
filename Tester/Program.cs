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

            using(StreamReader sr = new StreamReader(".\\хуй.test"))
            {
                text = sr.ReadToEnd();
            }

            Console.WriteLine(Encoding.ASCII.GetBytes("Q".ToString())[0]);

            var result = CaesarСypher.FrequencyAnalysis(text, Language.english);

            foreach (var item in result.Keys)
            {
                Console.WriteLine($"Буква {item} значение {result[item]}");
            }

            text = CaesarСypher.Coder(text.ToCharArray(), 5, Language.english);

            var key = CaesarСypher.VzlomJopi(text, Language.english);

            Console.WriteLine(key);

            Console.WriteLine(CaesarСypher.Decoder(text.ToCharArray(), key, Language.english));


            Console.ReadKey();
        }
    }
}
