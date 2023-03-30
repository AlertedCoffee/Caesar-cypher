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

    public class CaesarСypher
    {
        public string text;

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
                    count[c] += 1;
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

        private static double Avg(double[] values)
        {
            double sum = 0;
            foreach (var item in values)
            {
                sum+= item;
            }

            return sum / values.Length;
        }


        public static int VzlomJopi(string text, Language language)
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
                    break;
            }



            var deviation = new List<double>();
            var avgDeviations = new List<double>();

            for (int i = 0; i < dictionary.Length; i++)
            {
                text = Decoder(text.ToCharArray(), i, language);
                var frequency = FrequencyAnalysis(text, language);

                foreach (var c in frequency.Keys)
                {
                    deviation.Add(standard[Array.IndexOf(dictionary, c)] - frequency[c]);
                }

                avgDeviations.Add(MaxOf(deviation.ToArray()));


            }

            return Array.IndexOf(avgDeviations.ToArray(), MinOf(avgDeviations.ToArray()));
        }


        public static bool IsItOkay(double[] percents, Language language)
        {
            double[] standard = null;
            bool okay = true;

            switch (language)
            {
                case Language.russian:
                    standard = new double[] { 8.01, 1.59, 4.54, 1.7, 2.98, 8.45, 0.04, 0.94, 1.65, 7.35, 1.21, 3.49, 4.4, 3.21, 6.7, 10.97, 2.81, 4.73, 5.47, 
                                6.26, 2.62, 0.26, 0.97, 0.48, 1.44, 0.73, 0.36, 0.04, 1.9, 1.74, 0.32, 0.64, 2.01};
                    break;
                case Language.english:
                    //dictionary = new double[] {};
                    break;
            }

            for (int i = 0; i < standard.Length; i++)
            {
                if(percents[i] > standard[i] + 4 || percents[i] < standard[i] - 4)
                {
                    okay = false;
                }
            }

            return okay;

        }


        public class InvalidLanguageException : Exception 
        {
            public InvalidLanguageException(char c) : base("В алфавите выбранного языка нет символа " + c + $"(ASCII code: {Encoding.ASCII.GetBytes(c.ToString())[0]})") { }
        }
    }
}
