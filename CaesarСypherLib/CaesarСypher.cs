using System;
using System.Text;

namespace CaesarСypherLib
{
    /// <summary>
    /// Перечисление для выбора языка.
    /// </summary>
    public enum Language
    {
        /// <summary>
        /// Русский язык.
        /// </summary>
        russian,
        /// <summary>
        /// Английский язык.
        /// </summary>
        english
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
            if (text == null || text.Length == 0) throw new ArgumentNullException("text");


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
            if (dictionary == null || dictionary.Length == 0) throw new ArgumentNullException(nameof(dictionary));

            for (int i = 0; i < dictionary.Length; i++)
            {
                if (dictionary[i] == c) return i;
            }

            return -1;
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
