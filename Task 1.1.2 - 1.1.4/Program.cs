using System;
using Get;

namespace Task_1._1._2___1._1._4
{
    class Program
    {
        static void Main()
        {

            int line;

            while (true)
            {

                Console.Clear();

                Console.WriteLine("Выберете треугольник или елочку:" +
                "\n\t 1 - Triangle.\n\t 2 - Another Triangle. \n\t 3 - X-MAS Tree.");

                var dec = GetFromUser.GetPositiveIntNoMore(3, "Введите номер:");

                switch (dec)
                {
                    case (1):
                        line = GetFromUser.GetPositiveInt("Введите количество строк:");
                        Console.Clear();
                        StarTriangles.MakeTriangle(line);
                        Console.WriteLine("Нажмите любую клавишу что бы начать заного!");
                        break;

                    case (2):
                        line = GetFromUser.GetPositiveInt("Введите количество строк:");
                        Console.Clear();
                        StarTriangles.MakeAnotherTriangle(line);
                        Console.WriteLine("Нажмите любую клавишу что бы начать заного!");
                        break;

                    case (3):
                        line = GetFromUser.GetPositiveInt("Введите количество секций:");
                        Console.Clear();
                        StarTriangles.MakeXmasTree(line);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Нажмите любую клавишу что бы начать заного!");
                        break;

                }

                Console.ReadKey();
            }
        }
    }



    internal static class StarTriangles
    {
        /// <summary>
        /// Task 1.1.2
        /// </summary>
        internal static void MakeTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new String('*', i));
            }
        }


        /// <summary>
        /// Task 1.1.3
        /// </summary>
        internal static void MakeAnotherTriangle(int n, int maxSpaces = 0)
        {

            maxSpaces = maxSpaces == 0 ? n : maxSpaces;

            for (int i = 1, j = 1; i <= n; i++, j += 2)
            {
                var spaces = new string(' ', maxSpaces - i);
                var stars = new string('*', j);

                Console.WriteLine(String.Concat(spaces, stars));
            }

        }


        /// <summary>
        /// Task 1.1.4
        /// </summary>
        internal static void MakeXmasTree(int n)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 1; i <= n; i++)
            {
                MakeAnotherTriangle(i, n);
            }
        }
    }

}
