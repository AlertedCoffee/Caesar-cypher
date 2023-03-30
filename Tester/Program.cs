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

            var result = CaesarСypher.FrequencyAnalysis(text, Language.russian);

            foreach (var item in result.Keys)
            {
                Console.WriteLine($"Буква {item} значение {result[item]}");
            }


            Console.ReadKey();
        }
    }
}
