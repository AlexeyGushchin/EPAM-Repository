using Awards.BLL.Common;
using Awards.BLL.Dependencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AwardsWebPL
{
    public static class WebPL
    {
        public static IAwardsBLL Bll => AwardsBLLDependencies.AwardsBLL;
       
    }
}