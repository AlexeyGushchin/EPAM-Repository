using System;
using System.Linq;
using System.Text;
using Get;


namespace Task_1._2._4
{
    class Program
    {
        static void Main()
        {
            string example = "я плохо!? учил русский язык. забываю " +
                "начинать предложения... с заглавной. " +
                "хорошо, что можно написать программу!\n";

            Console.WriteLine("Если вы плохо учились в школе, " +
                "или у вас не работает Shift или Space Я вам помогу!\n" +
                "Строка для примера:\n");

            Console.WriteLine(example);

            string result = Validator(example);

            Console.WriteLine($"А вот результат:\n");
            Console.WriteLine(result);

            while (true)
            {

                example = GetFromUser.GetString("\nВведите свою строку;\n");
                    

                Console.Clear();

                Console.WriteLine("Ваша строка:\n");    
                Console.WriteLine(example);

                result = Validator(example);

                Console.WriteLine($"\nИсправленная строка:\n");
                Console.WriteLine(result);
            }
        }

        internal static string Validator(string text)
        {

            var result = new StringBuilder(text.Trim());
            CharToUpper(result, 0);

            int index = LastOfSeveralSeparators(result);

            if ((index < 0) || EndOfString(result, index))
                return result.ToString();


            while (index > 0)
            {
                if (NoSpaceAfter(result, index))
                    AddSpaceAfter(result, index);

                CharToUpper(result, index + 2);

                index = LastOfSeveralSeparators(result, index + 1);

                if (EndOfString(result, index))
                    return result.ToString();

            }

            return result.ToString();

        }



        
        internal static StringBuilder CharToUpper(StringBuilder text, int index)
        {
            text[index] = Char.ToUpper(text[index]);

            return text;
        }


        
        internal static bool NoSpaceAfter(StringBuilder text, int index)
        {
            return text[index + 1] != ' ';
        }

        
        internal static void AddSpaceAfter(StringBuilder text, int index)
        {
            text.Insert(index + 1, ' ');
        }


        /// <summary>
        /// Возвращает индекс символа конца предложения.
        /// В случае нескольких символов подряд возвращает индекс последнего
        /// </summary>
        internal static int LastOfSeveralSeparators(StringBuilder text, int index = 0)
        {
            string str = text.ToString();

            var separators = new char[] { '.', '!', '?' };

            index = str.IndexOfAny(separators, index);

            if (index < 0 || EndOfString(text, index))
                return index;

            while (true)
            {
                if (separators.Contains(str[index + 1]))
                {
                    index++;
                }
                else break;
            }

            return index;
        }


        /// <summary>
        /// Возможно этот метод избыточный но мне так нравится
        /// </summary>
        internal static bool EndOfString(StringBuilder text, int index)
        {
            return text.Length == (index + 1);
        }
    }
}
