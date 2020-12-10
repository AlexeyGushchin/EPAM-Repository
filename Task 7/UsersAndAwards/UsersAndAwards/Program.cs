using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Awards.PL.Dependencies;

namespace Awards
{
    public class Program
    {
        public static void Main()
        {
            var Pl = AwardsPLDependencies.AwardsPL;

            Pl.StartApp();

        }
    }

    
}
