using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weakest_link
{
    public enum Colors
    {
        None,
        Red,
        Yellow,
        Green,
        Black,
    }

    public static class ColorSetter
    {
        public static void SetColor(Colors color)
        {
            if (color == Colors.Black)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                return;
            }
            if (color == Colors.Green)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return;
            }
            if (color == Colors.Yellow)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                return;
            }
            if (color == Colors.Red)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return;
            }

        }
    }


}
