using Gothic___prequel.Bot;
using Gothic___prequel.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gothic___prequel
{
    class Program
    {
        static void Main()
        {
            var map = new MyMap();

            var game = new Game(map);

            game.LoadGame();

            var hero = game.map.StartHero;

            while (true)
            {
                
                var step = Step.GetNextPosition(Console.ReadKey(), hero);

                Step.GetResult(hero, step, map);

                



            }





        }
    }
}
