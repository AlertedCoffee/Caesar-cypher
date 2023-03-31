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

            while (true)
            {
                string text;

                using (StreamReader sr = new StreamReader(".\\хуй.test"))
                {
                    text = sr.ReadToEnd();
                }

                var lang = Language.russian;

                var result = CaesarСypher.FrequencyAnalysis(text, lang);

                foreach (var item in result.Keys)
                {
                    Console.WriteLine($"Буква {item} значение {result[item]}");
                }


                text = CaesarСypher.Coder(text.ToCharArray(), 5, lang);

                try
                {
                    var key = CaesarСypher.VzlomJopi(text, lang);
                    Console.WriteLine(key);

                    Console.WriteLine(CaesarСypher.Decoder(text.ToCharArray(), key, lang));
                }
                catch (CaesarСypher.NotEnoughSymbolsException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.Write("\n" + "Вы желаете продолжить? [Y/N]: ");
                    var dialigResult = Console.ReadKey();
                    if (dialigResult.KeyChar == 'y') 
                    {
                        var key = CaesarСypher.VzlomJopi(text, lang, true);

                        Console.WriteLine(CaesarСypher.Decoder(text.ToCharArray(), key, lang));
                    }
                }




                Console.ReadKey(); 
            }
        }
    }
}
