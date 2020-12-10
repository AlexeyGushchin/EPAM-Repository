using System;
using System.Collections.Generic;
using System.Linq;
using Awards.BLL.Common;
using Awards.DAL.Common;
using Awards.DAL.Dependencies;
using Awards.Entities;
using UsersAndAwards.Entities;

namespace Awards.BLL
{
    public class AwardsBLL : IAwardsBLL
    {
        public IAwardsDAL _dal;
        public List<User> _users;
        public List<Award> _awards;

        public AwardsBLL()
        {
            _dal = AwardsDALDependencies.AwardsDAL;
            _users = new List<User>();
            _awards = new List<Award>();
        }
        public void AddAwardToUser(User user, string awardName)
        {
            user.AddAward(awardName);

            for (var i = 0; i < _awards.Count(); i++)
            {
                if (_awards[i].Name == awardName)
                    _awards[i].AddUser(user);
            }
        }

        public void AddUser(User user)
        {
            _users.Add(user);
            SaveData();
        }

        public bool RemoveUser(User user) 
        {
            _users.Remove(user);
            SaveData();
            return true;
        }
        public void RemoveUserById(string id)
        {
            /*foreach(var user in _users)
            {
                var uId = user.Id.ToString();
                if (user.Id.ToString() == id)
                {
                    RemoveUser(user);
                }
            }*/
            var user = _users.Where(u => u.Id == id).FirstOrDefault();
            RemoveUser(user);
            
        }

        public IEnumerable<User> GetAllUsers() 
        {
            _users = _dal.GetAllUsers().ToList();
            return _users;
        }
        
        public IEnumerable<Award> GetAllAwards()
        {
            _awards = _dal.GetAllAwards().ToList();
            return _awards;
        }
        public IEnumerable<User> GetAwarderUsers(string awardName) =>
            from user in _users where user.awards.Contains(awardName) select user;
        
        public void SaveData()
        {
            _dal.SaveAppData(_users, _awards);
        }

        public void AddAward(string awardName)
        {
            var award = _awards.Where((a) => a.Name == awardName).FirstOrDefault();

            if (award == null)
                _awards.Add(new Award(awardName));
            SaveData();
        }

        public void RemoveAward(string awardName)
        {
            var award = _awards.Where((a) => a.Name == awardName).FirstOrDefault();

            if (award != null)
                _awards.Remove(award);
            SaveData();
        }
    }
}
