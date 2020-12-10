using Gothic___prequel.Bot;
using Gothic___prequel.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Gothic___prequel
{
   public class Step
    {

        public static Point GetNextPosition(ConsoleKeyInfo key, AbstractGameObject hero)
        {
            
            if(key == Step.Left)
                return new Point(hero.point.x - 1, hero.point.y);

            if (key == Step.Right)
                return new Point(hero.point.x + 1, hero.point.y);

            if (key == Step.Up)
                return new Point(hero.point.x, hero.point.y - 1);

            if (key == Step.Down)
                return new Point(hero.point.x, hero.point.y + 1);

            return null;

        }


       public static void GetResult(AbstractHero hero, Point newPosition, MyMap map)
        {
            int indexNewPosition = map.GetLength(newPosition);

            var oldPosition = hero.point;

            if (map.board[indexNewPosition] == ' ')
            {
                hero.point = newPosition;
                Writer.Write(hero);
                Writer.WriteSpace(oldPosition);
                return;
            }
            
        }




        static ConsoleKeyInfo Left = new ConsoleKeyInfo('\0', ConsoleKey.LeftArrow, false, false, false);
        static ConsoleKeyInfo Right = new ConsoleKeyInfo('\0', ConsoleKey.RightArrow, false, false, false);
        static ConsoleKeyInfo Up = new ConsoleKeyInfo('\0', ConsoleKey.UpArrow, false, false, false);
        static ConsoleKeyInfo Down = new ConsoleKeyInfo('\0', ConsoleKey.DownArrow, false, false, false);
    }
}
