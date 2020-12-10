using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_2._1._1
{
    public class CharacterString
    {
        #region FIELDS AND PROPERTIES

        public char[] text;

        public int Length
        {
            get { return text.Length; }
        }
        #endregion

        #region CONSTRUCTORS

        public CharacterString(string text)
        {
            this.text = text.ToCharArray();
        }

        public CharacterString(char[] text)
        {
            this.text = text;
        }

        public CharacterString(StringBuilder text)
        {
            this.text = text.ToString().ToCharArray();
        }

        #endregion


        public override string ToString() => new string(text);



        #region INDEXERS

        /// <summary>
        /// Обращение к массиву по индексу
        /// </summary>

        public char this[int index]
        {
            get { return text[index]; }

            set { text[index] = value; }

        }

        /// <summary>
        /// Получение массива индексов всех вхождений указанной буквы
        /// </summary>

        public int[] this[char _char]
        {
            get
            {
                var result = new List<int>();

                for (int i = 0; i < text.Length; i++)
                {
                    if (_char == text[i])
                        result.Add(i);
                }

                if (result.Count == 0)
                    result.Add(-1);

                return result.ToArray();
            }

        }

        /// <summary>
        /// Получения массива идексов всех вхождений подстроки
        /// </summary>
        /// 
        public int[] this[string sub]
        {
            get
            {
                var result = new List<int>();

                var arrOfFirstChar = this[sub[0]];

                foreach (var i in arrOfFirstChar)
                {
                    if (SameSubstring(sub, i))
                        result.Add(i);
                }

                if (result.Count == 0)
                    result.Add(-1);

                return result.ToArray();
            }
        }

        //public int[] this[string sub]
        //{
        //    get
        //    {
        //        var result = new List<int>();

        //        for (int i = 0; i < text.Length; i++)
        //        {
        //            if (sub[0] == text[i])
        //            {
        //                if (SameSubstring(sub, i))
        //                    result.Add(i);
        //            }

        //        }

        //        if (result.Count == 0)
        //            result.Add(-1);

        //        return result.ToArray();
        //    }
        //}

        #endregion


        #region EQUALS

        public bool Equals(CharacterString str)
        {
            if (ReferenceEquals(this, str))
                return true;

            if (this.Length != str.Length)
                return false;


            for( int i = 0; i < this.Length; i++)
            {
                if (this[i] != str[i])
                    return false;
            }

            return true;
        }



        #endregion


        #region GET METHODS
        /// <summary>
        /// Индекс первого вхождения буквы начиная с индекса startIndex или с начала 
        /// </summary>
        public int GetIndexOfChar(char _char, int startIndex = 0)
        {
            for (int i = startIndex; i < text.Length; i++)
            {
                if (_char == text[i])
                    return i;
            }

            return -1;
        }

        /// <summary>
        /// Получение индекса вхождения подстроки начиная с индекса startIndex или с начала
        /// </summary>

        public int GetIndexOfSubString(string sub, int startIndex = 0)
        {
            for (int i = startIndex; i < text.Length; i++)
            {
                if (sub[0] == text[i])
                {
                    if (SameSubstring(sub, i))
                        return i;
                }
            }

            return -1;
        }

        public int GetIndexOfSubString(char[] sub, int startIndex = 0)
        {
            for (int i = startIndex; i < text.Length; i++)
            {
                if (sub[0] == text[i])
                {
                    if (SameSubstring(sub, i))
                        return i;
                }
            }

            return -1;
        }

        #endregion


        #region OVERLOADS FOR OPERATORS
        /// <summary>
        ///  Сложение с собой со строкой и с массивом символов
        /// </summary>

        public static CharacterString operator +(CharacterString string1, CharacterString string2)
        {
            return new CharacterString(string1.text.Concat(string2.text).ToArray());
        }

        public static CharacterString operator +(CharacterString string1, string string2)
        {
            return new CharacterString(string1.text.Concat(string2).ToArray());
        }

        public static CharacterString operator +(CharacterString string1, char[] string2)
        {
            return new CharacterString(string1.text.Concat(string2).ToArray());
        }

        /// <summary>
        /// Сравнение длины с собой со строкой и с массивом символов
        /// </summary>

        public static bool operator >(CharacterString string1, CharacterString string2)
        {
            return string1.text.Length > string2.text.Length;
        }

        public static bool operator <(CharacterString string1, CharacterString string2)
        {
            return string1.text.Length < string2.text.Length;
        }

        public static bool operator >(CharacterString string1, string string2)
        {
            return string1.text.Length > string2.Length;
        }

        public static bool operator <(CharacterString string1, string string2)
        {
            return string1.text.Length < string2.Length;
        }

        public static bool operator >(CharacterString string1, char[] string2)
        {
            return string1.text.Length > string2.Length;
        }

        public static bool operator <(CharacterString string1, char[] string2)
        {
            return string1.text.Length < string2.Length;
        }


        #endregion



        #region REPLACE METHODS

        /// <summary>
        /// Замена символа
        /// </summary>
        public void ReplaceChar(char oldChar, char newChar)
        {
            for (int i = 0; i < text.Length; i++)
            {
                text[i] = text[i] == oldChar ? newChar : text[i];
            }
        }

        /// <summary>
        /// Замена подмассива
        /// </summary>

        public void ReplaceSubArray(char[] oldString, char[] newString)
        {
            text = this.ToStringBuilder().Replace(oldString.ToString(), newString.ToString()).ToString().ToCharArray();
        }

        public void ReplaceSubString(string oldString, string newString)
        {
            text = this.ToStringBuilder().Replace(oldString, newString).ToString().ToCharArray();
        }


        #endregion


        #region COUNT METHODS


        public Dictionary<char, int> CountOfEachChar()
        {
            var result = new Dictionary<char, int>();

            foreach (var i in text)
            {
                if (result.ContainsKey(i))
                    result[i]++;

                else result[i] = 1;
            }

            return result;

        }


        public void ShowCountOfEachChar()
        {
            foreach (KeyValuePair<char, int> i in this.CountOfEachChar())
                Console.WriteLine(i.Key + " - " + i.Value);
        }

        #endregion


        #region PRIVATE METHODS

        /// <summary>
        /// ПРоверяет входит ли указанная подстрока начиная с указанного индекса
        /// </summary>
        private bool SameSubstring(string sub, int index)
        {

            for (int i = 0; i < sub.Length; i++, index++)
            {
                if (index >= text.Length || text[index] != sub[i])
                    return false;
            }

            return true;
        }

        private bool SameSubstring(char[] sub, int index)
        {

            for (int i = 0; i < sub.Length; i++, index++)
            {
                if (index >= text.Length || text[index] != sub[i])
                    return false;
            }

            return true;
        }


        private StringBuilder ToStringBuilder() => new StringBuilder(this.ToString());


        #endregion



    }
}
