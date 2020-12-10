using System;
using StringOptions;
using Get;


namespace Task_1._2._1
{
    class Program
    {
        static void Main()
        {
            string example = "Викентий хорошо отметил день рождения: " +
                "покушал пиццу, посмотрел кино, пообщался со студентами в чате\n";

            Console.WriteLine("Подсчитаем среднюю длину слова в строке!\n" +
                "Строка для примера:\n");
            
            Console.WriteLine(example);

            double result = Averages(example);

            Console.WriteLine($"Средняя длина слова в данной строке равна {result}");

            while(true)
            {
                
                example = GetFromUser.GetString("\nВведите свою строку для подсчета:\n");

                Console.Clear();

                Console.WriteLine(example);
                result = Averages(example);

                Console.WriteLine($"\nСредняя длина слова в данной строке равна {result}");
            }


        }


        internal static double Averages(string text)
        {
            string[] words = MyString.TextToListWords(text);
            double counter = 0.0;

            foreach (var word in words)
            {
                counter += word.Length;
            }

            var result = counter / words.Length;

            return Math.Round(result);
            //округляем до ближайшего целого, половина буквы это странно))))

        }

        
    }
}
