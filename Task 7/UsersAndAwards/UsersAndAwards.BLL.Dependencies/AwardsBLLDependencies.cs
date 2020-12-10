using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Awards.BLL.Common;

namespace Awards.BLL.Dependencies
{
    public static class AwardsBLLDependencies
    {
        private static IAwardsBLL awardsBLL;
        public static IAwardsBLL AwardsBLL =>
            awardsBLL ?? (awardsBLL = new AwardsBLL());

    }
}
