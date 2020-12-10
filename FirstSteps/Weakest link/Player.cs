using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weakest_link
{
    class Player
    {
        public string name;

        public int x;
        public int y;

        
        public Player(string name, int x, int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
        }

        public void WritePlayer()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(name);
        }

        public void WriteColorPlayer(Colors color)
        {
            Console.SetCursorPosition(x, y);
            ColorSetter.SetColor(color);

            Console.Write(name);
            
        }
    }
}
