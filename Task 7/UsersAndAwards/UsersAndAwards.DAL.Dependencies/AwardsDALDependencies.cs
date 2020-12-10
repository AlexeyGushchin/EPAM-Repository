using Awards.DAL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Awards.DAL.Dependencies
{
    public static class AwardsDALDependencies
    {
        private static IAwardsDAL awardsDAL;
        public static IAwardsDAL AwardsDAL =>
            awardsDAL ?? (awardsDAL = new JsonAwardsDAL());

    }
}
