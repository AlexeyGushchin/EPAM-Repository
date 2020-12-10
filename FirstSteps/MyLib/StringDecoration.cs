using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MyLib
{
    public static class StringDecoration
    {
        public static void MovingString(string text, int x, int y, int speed)
        {
            string part = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.SetCursorPosition(x, y);
                part = String.Concat(text[i], part);
                Console.WriteLine(part);
                Thread.Sleep(speed);
            }
        }

        public static void BlinkString(string text, int x, int y)
        {
            int time = 7;
            while (time != 0)
            {
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(text);
                Thread.Sleep(50);

                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(text);
                Thread.Sleep(50);

                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(text);
                Thread.Sleep(50);

                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(text);
                Thread.Sleep(50);

                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(text);
                Thread.Sleep(50);

                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(text);
                Thread.Sleep(50);

                time--;
            }
        }

        public static void LoadingImitation(string text, int x, int y)
        {
            var delay = new Random().Next(1, 100);
            int percentX = x + 20;
            int barX = x + 8;
            string bar = "";

            Console.SetCursorPosition(x, y);
            Console.CursorVisible = false;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text + " ");

            for (int i = 0; i <= 100; i++)
            {
                Console.SetCursorPosition(percentX, y);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{i} %");
                Thread.Sleep(30);
                if (i % 10 == 0)
                {
                    Console.SetCursorPosition(barX, y);
                    Console.ForegroundColor = ConsoleColor.Green;
                    bar = String.Concat(bar, "*");
                    Console.WriteLine(bar);
                }

                if (i == delay)
                    Thread.Sleep(1000);
            }

            Thread.Sleep(1000);
            Console.ResetColor();
        }


        public static void MoveAndBlinK(string text, int x, int y, int speed)
        {
            MovingString(text, x, y, speed);
            Thread.Sleep(500);
            BlinkString(text, x, y);
            Thread.Sleep(500);
        }
    }
}
