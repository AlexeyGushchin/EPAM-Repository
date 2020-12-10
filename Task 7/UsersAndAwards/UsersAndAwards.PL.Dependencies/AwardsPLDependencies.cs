using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Awards.PL.Common;
using Awards.PLConsole;

namespace Awards.PL.Dependencies
{
    public static class AwardsPLDependencies
    {
        private static IAwardsPL awardsPL;
        public static IAwardsPL AwardsPL => 
            awardsPL ?? (awardsPL = new AwardsConsolePL());

    }
}
