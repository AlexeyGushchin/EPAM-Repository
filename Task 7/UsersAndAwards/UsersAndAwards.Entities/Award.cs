using Awards.Entities;
using System.Collections.Generic;

namespace UsersAndAwards.Entities
{
    public class Award
    {
        public string Name { get; set; }
        public List<User> AwardedUsers { get; set; }

        public Award() { }
        public Award(string name)
        {
            Name = name;
        }
        

        public void AddUser(User user)
        {
            AwardedUsers.Add(user);
        }
    }
}
