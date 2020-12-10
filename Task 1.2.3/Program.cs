using System;
using Get;
using StringOptions;

namespace Task_1._2._3
{
    class Program
    {
        static void Main()
        {
            string example = "Антон хорошо начал утро: послушал Стинга, " +
                "выпил кофе и посмотрел Звёздные Войны\n";

            Console.WriteLine("Подсчитаем количество слов, начинающихся с маленькой буквы!\n" +
                "Строка для примера:\n");

            Console.WriteLine(example);

            int result = LowerCase(example);

            Console.WriteLine($"Количество слов в данной строке, " +
                $"начинающихся с маленькой буквы равно {result}");

            while (true)
            {

                example = GetFromUser.GetString("\nВведите свою строку для подсчета:\n");

                Console.Clear();

                Console.WriteLine(example);
                result = LowerCase(example);

                Console.WriteLine($"Количество слов в данной строке, " +
                $"начинающихся с маленькой буквы равно {result}");
            }


        }


        internal static int LowerCase(string text)
        {
            int counter = 0;

            foreach (var word in MyString.TextToListWords(text))
            {
                if (Char.IsLower(word[0]))
                {
                    counter++;
                }
            }

            return counter;
        }

    }
}
