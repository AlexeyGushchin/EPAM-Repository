using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndAwards.Entities;

namespace Awards.Entities
{
    public class User
    {
        public string Id { get;  set; }
        public string Name { get;  set; }
        public DateTime DateOfBirth { get;  set; }
        public uint Age { get;  set; }

        public List<string> awards;

        public User() { }
        
        public User(string name, DateTime dateOfBirth, uint age) 
        {
            Id = Guid.NewGuid().ToString();
            awards = new List<string>();
            Name = name;
            DateOfBirth = dateOfBirth;
            Age = age;
        }

        

        public void AddAward(string award)
        {
            if (awards.Contains(award))
            {
                return;
            }
            awards.Add(award);
        }

        public List<string> GetAwards() => awards;
    }
}
