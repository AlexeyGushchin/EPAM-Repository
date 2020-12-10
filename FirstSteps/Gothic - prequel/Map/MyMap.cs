

using Gothic___prequel.Bot;
using System.Collections.Generic;

namespace Gothic___prequel.Map
{
    public class MyMap 
    {
        public int width = 77;
        public int height = 26;
        public string board = "" +
            "****************************************************************************\n" +
            "*                                                                          *\n" +
            "*                                                                          *\n" +
            "*                                                                          *\n" +
            "*       |_____|                                                            *\n" +
            "*                                                                          *\n" +
            "*                                                                          *\n" +
            "*                                                                          *\n" +
            "*                                                                          *\n" +
            "*                                                                          *\n" +
            "*                                                                          *\n" +
            "*                                                                          *\n" +
            "*                                                                          *\n" +
            "*                                                                          *\n" +
            "*      ^^^^^                                                               *\n" +
            "*      ^^^^^                                                               *\n" +
            "*      ^^^^^                                                               *\n" +
            "*                                                                          *\n" +
            "*                                                                          *\n" +
            "*                                                                          *\n" +
            "*                                                                          *\n" +
            "*                                                   _____                  *\n" +
            "*                                                  |     |                 *\n" +
            "*                                                                          *\n" +
            "*                                                                          *\n" +
            "****************************************************************************";




        public List<AbstractEnemy> StartEnemy = new List<AbstractEnemy>
        {
            new Enemy(new Point(30, 10)),
            new Enemy(new Point(31, 10)),
            new Enemy(new Point(32, 10)),
            new Enemy(new Point(34, 10)),
            new Enemy(new Point(35, 10)),
            new Enemy(new Point(36, 10))
        };

        public AbstractEnemy StartBeliar = new Beliar(new Point(33, 10));

        public AbstractHero StartHero = new Hero(new Point(33, 20));

        public Point GetCursorePosition(int index)
        {
            var x = index % width;
            var y = index / width;

            return new Point(x, y);
        }

        public int GetLength(Point point)
        {
            return point.y * width + point.x;
        }


    }
}
