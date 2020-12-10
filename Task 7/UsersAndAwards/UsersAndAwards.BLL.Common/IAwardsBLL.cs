using System;
using System.Collections.Generic;
using Awards.Entities;
using UsersAndAwards.Entities;

namespace Awards.BLL.Common
{
    public interface IAwardsBLL
    {
        void AddUser(User user);
        bool RemoveUser(User user);
        void RemoveUserById(string id);
        void AddAward(string awardName);
        void RemoveAward(string awardName);
        void AddAwardToUser(User user, string awardName);
        IEnumerable<User> GetAllUsers();
        IEnumerable<Award> GetAllAwards();
        IEnumerable<User> GetAwarderUsers(string awardName);
        void SaveData();

    }
}
