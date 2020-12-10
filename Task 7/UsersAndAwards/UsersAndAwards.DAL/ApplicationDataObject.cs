using Awards.Entities;
using System.Collections.Generic;
using UsersAndAwards.Entities;

namespace UsersAndAwards.DAL
{
    public class ApplicationDataObject
    {
        public List<User> _users;
        public List<Award> _awards;

        public ApplicationDataObject()
        {
            _users = new List<User>();
            _awards = new List<Award>();
        }

        public ApplicationDataObject(List<User> users, List<Award> awards)
        {
            _users = users;
            _awards = awards;
        }
    }
}
