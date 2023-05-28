using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaesarСypherLib
{
    /// <summary>
    /// Перечисление для выбора языка.
    /// </summary>
    public enum Language { 
        /// <summary>
        /// Русский язык.
        /// </summary>
        russian = 33,
        /// <summary>
        /// Английский язык.
        /// </summary>
        english = 26
    }

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
        /// <returns>Строка зашифрованного текст</returns>
        /// <exception cref="ArgumentNullException">Исключение при пустом входном тексте</exception>
        /// <exception cref="InvalidLanguageException">Исключение при отсутствии символа в выбранном алфавите</exception>
        public static string Coder(char[] text, int key, Language language)
        {
            if(text == null || text.Length == 0) throw new ArgumentNullException("text");


            char[] dictionary = null;
            char[] dictionaryUpper = null;

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

            // Нормализация параметра key.
            if (key < 0) key = key % dictionary.Length + dictionary.Length;
            else key %= dictionary.Length;

            
            string newString = "";

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

                    var newPosition = (position + key) % dictionary.Length;
                    newString += upper ? dictionaryUpper[newPosition] : dictionary[newPosition];
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
        /// <returns>Строка дешифрованного текст</returns>
        /// <exception cref="ArgumentNullException">Исключение при пустом входном тексте</exception>
        /// <exception cref="InvalidLanguageException">Исключение при отсутствии символа в выбранном алфавите</exception>
        public static string Decoder(char[] text, int key, Language language) => Coder(text, key * -1, language);


        /// <summary>
        /// Метод поиска символа в словаре.
        /// </summary>
        /// <param name="dictionary">Алфавит типа char[]</param>
        /// <param name="c">искомый параметр типа char</param>
        /// <returns>Индекс найденного элемента, -1 при отсутствии</returns>
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
        /// <param name="text">Входной текст для анализа</param>
        /// <param name="language">Выбор алфавита</param>
        /// <returns>Словарь частотности, где ключ - буква алфавита, value - частоты использования в тексте в процентах</returns>
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

            int trueLenght = 0;

            foreach (var c in text.ToCharArray())
            {
                if (char.IsLetter(c))
                {
                    try
                    {
                        count[c] += 1;
                        trueLenght += 1;
                    }
                    catch (System.Collections.Generic.KeyNotFoundException) 
                    {
                        throw new InvalidLanguageException(c);
                    }
                }
            }

            foreach(var c in count.Keys)
            {
                frequency[c] = count[c] / trueLenght * 100;
            }

            return frequency;
        }


        /// <summary>
        /// Метод взлома шифра Цезаря частотным анализом.
        /// </summary>
        /// <param name="text">Входной текст</param>
        /// <param name="language">Язык шифра</param>
        /// <param name="ignoreNotEnoughSymbolsException">Флаг для игнорирования исключения при недостаточном кол-ве символов для взлома шифра</param>
        /// <returns>Ключ шифра</returns>
        /// <exception cref="ArgumentNullException">Исключение при не инициализированном text</exception>
        /// <exception cref="ArgumentException">Исключение при пустой строке text</exception>
        /// <exception cref="NotEnoughSymbolsException">Исключение при недостаточном кол-ве символов для взлома шифра</exception>
        public static int HackCypher(string text, Language language, bool ignoreNotEnoughSymbolsException = false)
        {
            if (text == null) throw new ArgumentNullException(nameof(text));
            if (text == "") throw new ArgumentException("text не может быть пустым");


            char[] dictionary = null;
            int standartMostFrequentIndex = 0;

            switch (language)
            {
                case Language.russian:
                    dictionary = _russianDictiondry.ToCharArray();
                    standartMostFrequentIndex = 15;
                    break;
                case Language.english:
                    dictionary = _englishDictiondry.ToCharArray();
                    standartMostFrequentIndex = 4;
                    break;
            }

            var frequency = FrequencyAnalysis(text, language);

            if (!IsItOkay(frequency.Values.ToArray(), language) && !ignoreNotEnoughSymbolsException) throw new NotEnoughSymbolsException();

            var mostFrequentLetter = frequency.OrderByDescending(x => x.Value).First().Key;
            int indexOfMostFrequent = Array.IndexOf(dictionary, mostFrequentLetter);

            var key = indexOfMostFrequent - standartMostFrequentIndex;

            if (key < 0)
            {
                key += dictionary.Length;
            }

            return key;
        }

        /// <summary>
        /// Метод проверки полноты использования символов алфавита.
        /// </summary>
        /// <param name="values">Массив значений</param>
        /// <param name="language">Язык алфавита</param>
        /// <returns>true - при достаточно полном использовании алфавита, иначе false</returns>
        /// <exception cref="ArgumentNullException">Исключение при пустом массиве</exception>
        private static bool IsItOkay(double[] values, Language language)
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
        /// Метод взлома шифра Цезаря по известной части исходного текста.
        /// </summary>
        /// <param name="text">Входной текст</param>
        /// <param name="knownPlainText">Известная часть исходного текста</param>
        /// <param name="lang">Язык шифра</param>
        /// <returns>Ключ текста или -1, если не удалось найти известную часть текста</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static int HackCypher(string text, string knownPlainText, Language lang)
        {
            if (text == null) throw new ArgumentNullException(nameof(text));
            if (text == "") throw new ArgumentException("text не может быть пустым");

            if (knownPlainText == null) throw new ArgumentNullException(nameof(knownPlainText));
            if (knownPlainText == "") throw new ArgumentException("knownPlainText не может быть пустым");



            for (int i = 0; i < ((int)lang); i++)
            {
                int index = Decoder(text.ToCharArray(), i, lang).IndexOf(knownPlainText);
                if (index != -1) return i;
            }
            return -1;
        }


        /// <summary>
        /// Исключение, которое выдается, когда набор символов в тексте слишком мал для точного взлома шифра.
        /// </summary>
        public class NotEnoughSymbolsException : Exception
        {
            /// <summary>
            /// Конструктор по-умолчанию.
            /// </summary>
            public NotEnoughSymbolsException() : base("Набор символов в тексте слишком мал для точного взлома шифра."){ }
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
