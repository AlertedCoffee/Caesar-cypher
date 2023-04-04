using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CaesarСypherLib
{
    public enum Language { russian, english }

    public static class CaesarСypher
    {
        private static string _russianDictiondry = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        private static string _russianDictiondryUpper = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        private static string _englishDictiondry = "abcdefghijklmnopqrstuvwxyz";
        private static string _englishDictiondryUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";



        public static string Coder(char[] text, int key, Language language)
        {


            char[] dictionary = null;
            char[] dictionaryUpper = null;
            string newString = "";

            switch (language)
            {
                case Language.russian:
                    dictionary = _russianDictiondry.ToCharArray();
                    dictionaryUpper = _russianDictiondryUpper.ToCharArray();
                    break;
                case Language.english:
                    dictionary = _englishDictiondry.ToCharArray();
                    dictionaryUpper = _englishDictiondryUpper.ToCharArray();
                    break;
            }

            if (key < 0) key = key % dictionary.Length + dictionary.Length;
            else key %= dictionary.Length;


            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    bool upper = false;
                    var position = FindIndex(dictionary, c);
                    if (position == -1) 
                    {
                        upper = true;
                        position = FindIndex(dictionaryUpper, c); 
                    }

                    if (position == -1) throw new InvalidLanguageException(c);


                    newString += upper ? dictionaryUpper[(position + key) % dictionary.Length] : dictionary[(position + key) % dictionary.Length];
                }
                else
                {
                    newString += c;
                }
            }

            return newString;
        }

        public static string Decoder(char[] text, int key, Language language) => Coder(text, key * -1, language);

        private static int FindIndex(char[] dictionary, char c)
        {
            for (int i = 0; i < dictionary.Length; i++)
            {
                if (dictionary[i] == c) return i;
            }
            
            return -1;
        }

        public static Dictionary<char, double> FrequencyAnalysis(string text, Language language)
        {
            text = text.ToLower();

            char[] dictionary = null;

            switch (language)
            {
                case Language.russian:
                    dictionary = _russianDictiondry.ToCharArray();
                    break;
                case Language.english:
                    dictionary = _englishDictiondry.ToCharArray();
                    break;
            }

            Dictionary<char, double> count = new Dictionary<char, double>();

            Dictionary<char, double> frequency = new Dictionary<char, double>();


            foreach (var c in dictionary)
            {
                count.Add(c, 0);
                frequency.Add(c, 0);
            }

            foreach(var c in text.ToCharArray())
            {
                if (char.IsLetter(c))
                {
                    try
                    {
                        count[c] += 1;
                    }
                    catch (System.Collections.Generic.KeyNotFoundException) 
                    {
                        throw new InvalidLanguageException(c);
                    }
                }
            }

            foreach(var c in count.Keys)
            {
                frequency[c] = count[c] / text.Length * 100;
            }

            return frequency;
        }


        private static double MaxOf(double[] values) 
        {
            double max = values[0];

            foreach(var elem  in values)
            {
                max = Math.Max(max, elem);
            }

            return max;
        }


        private static double MinOf(double[] values)
        {
            double min = values[0];

            foreach (var elem in values)
            {
                min = Math.Min(min, elem);
            }

            return min;
        }


        public static int VzlomJopi(string text, Language language, bool ignoreNotEnoughSymbolsException = false)
        {

            char[] dictionary = null;
            double[] standard = null;

            switch (language)
            {
                case Language.russian:
                    dictionary = _russianDictiondry.ToCharArray();
                    standard = new double[] { 8.01, 1.59, 4.54, 1.7, 2.98, 8.45, 0.04, 0.94, 1.65, 7.35, 1.21, 3.49, 4.4, 3.21, 6.7, 10.97, 2.81, 4.73, 5.47,
                                6.26, 2.62, 0.26, 0.97, 0.48, 1.44, 0.73, 0.36, 0.04, 1.9, 1.74, 0.32, 0.64, 2.01};
                    break;
                case Language.english:
                    dictionary = _englishDictiondry.ToCharArray();
                    standard = new double[] { 8.17, 1.49, 2.78, 4.25, 12.7, 2.23, 2.02, 6.09, 6.97, 0.15, 0.77, 4.03, 2.41, 6.75, 7.51, 1.93, 0.1, 5.99, 6.33,
                                9.06, 2.76, 0.98, 2.36, 0.15, 1.97, 0.07 };
                    break;
            }

            var frequency = FrequencyAnalysis(text, language);

            if (!IsItOkay(frequency.Values.ToArray()) && !ignoreNotEnoughSymbolsException) throw new NotEnoughSymbolsException();


            var maxDeviations = new List<double>();

            for (int i = 0; i <= dictionary.Length; i++)
            {
                var deviations = new List<double>();

                text = Decoder(text.ToCharArray(), 1, language);
                frequency = FrequencyAnalysis(text, language);

                foreach (var c in frequency.Keys)
                {
                    deviations.Add(standard[Array.IndexOf(dictionary, c)] - frequency[c]);
                }

                maxDeviations.Add(MaxOf(deviations.ToArray()));


            }

            return Array.IndexOf(maxDeviations.ToArray(), MinOf(maxDeviations.ToArray())) + 1;
        }

        public static bool IsItOkay(double[] values)
        {
            int counter = 0;
            foreach (var item in values)
            {
                if (item != 0) counter++;

            }
            Console.WriteLine(Math.Round((double)counter / values.Length, 1));

            return (Math.Round((double)counter / values.Length, 1) >= 0.5);
        }

        public class NotEnoughSymbolsException : Exception
        {
            public NotEnoughSymbolsException() : base("В тексте недостаточно символов для точного взлома шифра."){ }
        }


        public class InvalidLanguageException : Exception 
        {
            public InvalidLanguageException(char c) : base("В алфавите выбранного языка нет символа " + c + $"(ASCII code: {Encoding.ASCII.GetBytes(c.ToString())[0]}).") { }
        }
    }
}
