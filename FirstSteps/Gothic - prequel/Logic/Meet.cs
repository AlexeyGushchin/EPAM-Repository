using Gothic___prequel.Bot;
using Gothic___prequel.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gothic___prequel
{
   public  class Meet
    {
        public static void GoToTheEmptyPlace(AbstractHero hero, Point point)
        {
            hero.point = point;
            Writer.Write(hero);
        }
    }
}
