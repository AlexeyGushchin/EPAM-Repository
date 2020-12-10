using System;
using System.Linq;
using System.Text;
using Get;


namespace Task_1._2._2
{
    class Program
    {
        static void Main()
        {
            string example = "написать программу, которая";
            string doubler = "описание";


            Console.WriteLine("Пример!\nДана строка:\n");
            Console.WriteLine(example);

            Console.WriteLine("\nВторая строка:\n");
            Console.WriteLine(doubler);

            Console.WriteLine("\nПосле удвоения в первой строке символов из второй:\n");
            Console.WriteLine(Doubler(example, doubler));

            Console.WriteLine("\nЕсли этот невероятный функционал покажется Вам полезным, " +
                "пользуйтесь на здоровье!!\nНажмите любую клавишу что бы начать!");
            Console.ReadKey();
            Console.Clear();

            while (true)
            {
                example = GetFromUser.GetString("\nВведите строку для удвоения:\n");

                doubler = GetFromUser.GetString("\nВведите строку дублёр:\n");

                Console.WriteLine("\nПосле удвоения в первой строке символов из второй:\n");
                Console.WriteLine(Doubler(example, doubler));

                Console.ReadKey();
                Console.Clear();



            }
        }

        internal static string Doubler(string text, string doubler)
        {
            var result = new StringBuilder(text.Length);

            foreach (char _char in text)
            {
                result.Append(_char);

                if (doubler.Contains(_char))
                    result.Append(_char);

            }

            return result.ToString();
        }
    }
}
