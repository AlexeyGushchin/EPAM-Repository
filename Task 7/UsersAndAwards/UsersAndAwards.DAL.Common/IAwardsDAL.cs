using Awards.Entities;
using System.Collections.Generic;
using UsersAndAwards.Entities;

namespace Awards.DAL.Common
{
    public interface IAwardsDAL
    {
        void SaveAppData(IEnumerable<User> users, IEnumerable<Award> awards);
        IEnumerable<User> GetAllUsers();
        IEnumerable<Award> GetAllAwards();
    }
}
