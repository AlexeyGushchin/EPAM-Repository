using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gothic___prequel
{
    public class ColorSetter
    {
        public static void SetColor(Color color)
        {
            if (color == Color.White)
            {
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            if (color == Color.Blue)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                return;
            }
            if (color == Color.DarkBlue)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                return;
            }
            if (color == Color.DarkGreen)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                return;
            }
            if (color == Color.DarkRed)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                return;
            }
            if (color == Color.DarkYellow)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                return;
            }
            if (color == Color.Green)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return;
            }
            if (color == Color.Red)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return;
            }
            if (color == Color.Yellow)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                return;
            }
        }
    }
}
