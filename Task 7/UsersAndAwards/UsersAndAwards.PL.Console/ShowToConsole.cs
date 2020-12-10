using Awards.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersAndAwards.PLConsole
{
    public static class ConsolePages
    {
        public static void StartPage()
        {
            Console.CursorVisible = false;
            Console.Clear();

            Console.WriteLine("add - add user");
            Console.WriteLine("users - show all users");
            Console.WriteLine("awards - show all awards");
            Console.WriteLine("x - close the app");
            Console.WriteLine("write a command:");
        }

        public static void ShowUserInformation(User user)
        {
            Console.WriteLine("User:" + Environment.NewLine +
                "id : " + user.Id + Environment.NewLine +
                "name : " + user.Name + Environment.NewLine +
                "date of birth : " + user.DateOfBirth +
                "age : " + user.Age + Environment.NewLine);

            if(user.awards.Count == 0)
            {
                Console.WriteLine("User doesn't have any awards");
            }
            else
            {
                Console.WriteLine("User's awards:" + Environment.NewLine);
                foreach(var award in user.awards)
                    Console.WriteLine(award);
            }
        }

        public static void ShowUsersInformation(IEnumerable<User> users)
        {
            foreach (var user in users)
            {
                ShowUserInformation(user);
                Console.WriteLine();
            }
        }
    }
}
