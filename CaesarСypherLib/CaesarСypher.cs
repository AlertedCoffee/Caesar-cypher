using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CaesarСypherLib
{
    /// <summary>
    /// Перечисление для выбора языка.
    /// </summary>
    public enum Language { russian, english }

    /// <summary>
    /// Статический класс для шифровки, дешифровки и взлома шифра Цезаря.
    /// </summary>
    public static class CaesarСypher
    {
        /// <summary>
        /// Набор букв русского алфавита в нижнем регистре.
        /// </summary>
        private static string _russianDictiondry = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        /// <summary>
        /// Набор букв русского алфавита в верхнем регистре. 
        /// </summary>
        private static string _russianDictiondryUpper = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        /// <summary>
        /// Набор букв английского алфавита в нижнем регистре.
        /// </summary>
        private static string _englishDictiondry = "abcdefghijklmnopqrstuvwxyz";

        /// <summary>
        /// Набор букв английского алфавита в верхнем регистре. 
        /// </summary>
        private static string _englishDictiondryUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";


        /// <summary>
        /// Метод зашифровки текста шифром Цезаря.
        /// </summary>
        /// <param name="text">Входной текст типа char[]</param>
        /// <param name="key">Ключ шифра типа int</param>
        /// <param name="language">Язык исходного текста Language</param>
        /// <returns>string зашифрованный текст</returns>
        /// <exception cref="ArgumentNullException">Исключение при пустом входном тексте</exception>
        /// <exception cref="InvalidLanguageException">Исключение при отсутствии символа в выбранном алфавите</exception>
        public static string Coder(char[] text, int key, Language language)
        {
            if(text == null || text.Length == 0) throw new ArgumentNullException("text");


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

        /// <summary>
        /// Метод дешифровки текста шифром Цезаря.
        /// </summary>
        /// <param name="text">Входной текст типа char[]</param>
        /// <param name="key">Ключ шифра типа int</param>
        /// <param name="language">Язык исходного текста Language</param>
        /// <returns>string дешифрованный текст</returns>
        /// <exception cref="ArgumentNullException">Исключение при пустом входном тексте</exception>
        /// <exception cref="InvalidLanguageException">Исключение при отсутствии символа в выбранном алфавите</exception>
        public static string Decoder(char[] text, int key, Language language) => Coder(text, key * -1, language);

        /// <summary>
        /// Метод поиска символа в алфавите.
        /// </summary>
        /// <param name="dictionary">Алфавит типа char[]</param>
        /// <param name="c">искомый параметр типа char</param>
        /// <returns>index найденного элемента, -1 при отсутствии</returns>
        /// <exception cref="ArgumentNullException">Исключение при пустом словаре</exception>
        private static int FindIndex(char[] dictionary, char c)
        {
            if (dictionary == null ||  dictionary.Length == 0) throw new ArgumentNullException(nameof(dictionary));

            for (int i = 0; i < dictionary.Length; i++)
            {
                if (dictionary[i] == c) return i;
            }
            
            return -1;
        }


        /// <summary>
        /// Метод вычисления частотного анализа символов в тексте.
        /// </summary>
        /// <param name="text">Входной текст для анализа типа string</param>
        /// <param name="language">Выбор алфавита Language</param>
        /// <returns>Dictionary<char, double>, где ключ - буква алфавита, value - частоты использования в тексте в %.</returns>
        /// <exception cref="ArgumentNullException">Исключение при не инициализированном text</exception>
        /// <exception cref="ArgumentException">Исключение при пустой строке text</exception>
        /// <exception cref="InvalidLanguageException">Исключение при отсутствии символа в выбранном алфавите</exception>
        public static Dictionary<char, double> FrequencyAnalysis(string text, Language language)
        {
            if (text == null) throw new ArgumentNullException("text");
            if(text == "") throw new ArgumentException("text не может быть пустым");


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


        /// <summary>
        /// Метод нахождения максимального значения в массиве.
        /// </summary>
        /// <param name="values">Массив double[]</param>
        /// <returns>максимальное значение double</returns>
        /// <exception cref="ArgumentNullException">Исключение при пустом массиве values</exception>
        private static double MaxOf(double[] values) 
        {
            if(values == null || values.Length == 0) throw new ArgumentNullException(nameof(values));


            double max = values[0];

            foreach(var elem  in values)
            {
                max = Math.Max(max, elem);
            }

            return max;
        }


        /// <summary>
        /// Метод нахождения минимального значения в массиве.
        /// </summary>
        /// <param name="values">Массив double[]</param>
        /// <returns>минимальное значение double</returns>
        /// <exception cref="ArgumentNullException">Исключение при пустом массиве values</exception>
        private static double MinOf(double[] values)
        {
            if (values == null || values.Length == 0) throw new ArgumentNullException(nameof(values));


            double min = values[0];

            foreach (var elem in values)
            {
                min = Math.Min(min, elem);
            }

            return min;
        }


        /// <summary>
        /// Метод взлома шифра Цезаря.
        /// </summary>
        /// <param name="text">Входной текст типа string</param>
        /// <param name="language">Язык исходного текста Language</param>
        /// <param name="ignoreNotEnoughSymbolsException">Флаг для игнорирования исключения при недостаточном кол-ве символов для взлома шифра</param>
        /// <returns>ключ шифра int</returns>
        /// <exception cref="ArgumentNullException">Исключение при не инициализированном text</exception>
        /// <exception cref="ArgumentException">Исключение при пустой строке text</exception>
        /// <exception cref="NotEnoughSymbolsException">Исключение при недостаточном кол-ве символов для взлома шифра</exception>
        public static int HackCypher(string text, Language language, bool ignoreNotEnoughSymbolsException = false)
        {
            if (text == null) throw new ArgumentNullException(nameof(text));
            if (text == "") throw new ArgumentException("text не может быть пустым");


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
                //if (maxDeviations[maxDeviations.Count - 1] > 12.5 && !ignoreNotEnoughSymbolsException) throw new NotEnoughSymbolsException();

            }

            return Array.IndexOf(maxDeviations.ToArray(), MinOf(maxDeviations.ToArray())) + 1;
        }

        /// <summary>
        /// Метод проверки полноты использования символов алфавита.
        /// </summary>
        /// <param name="values">массив значений double[]</param>
        /// <returns>bool. true - при достаточно полном использовании алфавита, иначе false</returns>
        /// <exception cref="ArgumentNullException">Исключение при пустом массиве</exception>
        private static bool IsItOkay(double[] values)
        {
            if(values == null || values.Length == 0) throw new ArgumentNullException("values");


            int counter = 0;
            foreach (var item in values)
            {
                if (item != 0) counter++;

            }
            Console.WriteLine(Math.Round((double)counter / values.Length, 1));

            return (Math.Round((double)counter / values.Length, 1) >= 0.5);
        }

        /// <summary>
        /// Исключение, которое выдается, когда в тексте недостаточно символов для точного взлома шифра.
        /// </summary>
        public class NotEnoughSymbolsException : Exception
        {
            /// <summary>
            /// Конструктор по-умолчанию.
            /// </summary>
            public NotEnoughSymbolsException() : base("В тексте недостаточно символов для точного взлома шифра."){ }
        }

        /// <summary>
        /// Исключение, которое выдается, когда в алфавите выбранного языка нет символа.
        /// </summary>
        public class InvalidLanguageException : Exception 
        {
            /// <summary>
            /// Конструктор с параметром буквы, которая вызвала ошибку.
            /// </summary>
            /// <param name="c">буква ошибки char</param>
            public InvalidLanguageException(char c) : base("В алфавите выбранного языка нет символа " + c + $"(ASCII code: {Encoding.ASCII.GetBytes(c.ToString())[0]}).") { }
        }
    }
}
