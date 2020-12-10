using Gothic___prequel.Bot;
using Gothic___prequel.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gothic___prequel
{
    class Game
    {

        public MyMap map;
        public Game (MyMap map)
        {
            this.map = map;
        }
        public void LoadGame()
        {
            Console.WriteLine(map.board);

            WriteStartEnemy();
        }

        public void WriteStartEnemy()
        {
            Writer.WriteSame(map.StartEnemy);
            Writer.Write(map.StartBeliar);
            Writer.Write(map.StartHero);
        }
    }
}
