using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime
{
    public static class OrdersWriter
    {
        readonly static int x = 40;
        private static int y = 0;

        private static int lineCount = 10;

        public static void GiveOrder(string message)
        {
            
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(message);
            Console.ResetColor();

            y++;
            lineCount--;

            if (lineCount == 0)
            {
                lineCount = 10;
                y = 0;
            }
        }

    }
}
