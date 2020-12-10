using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Awards.BLL.Common;
using Awards.BLL.Dependencies;
using Awards.Entities;
using Awards.PL.Common;
using UsersAndAwards.PLConsole;

namespace Awards.PLConsole
{
    public class AwardsConsolePL : IAwardsPL
    {
        private IAwardsBLL _bll;
        public AwardsConsolePL()
        {
            _bll = AwardsBLLDependencies.AwardsBLL;
        }

        public void StartApp()
        {
            while (true)
            {
                ConsolePages.StartPage();

                switch (Console.ReadLine())
                {
                    case "add":
                        _bll.AddUser(CreateNewUser());
                        break;
                    case "users":
                        ConsolePages.ShowUsersInformation(_bll.GetAllUsers());
                        Thread.Sleep(10000);
                        break;
                    case "awards":
                        break;
                    case "x":
                        _bll.SaveData();
                        Environment.Exit(0);
                        break;

                }
            }
        }

        public User CreateNewUser()
        {
            Console.Clear();

            var name = GetFromUser.GetString("Enter your name:");
            var dateOfBirth = GetFromUser.GetDate("Enter your date of bitrh:");
            var age = GetFromUser.GetPositiveNumber("Enter your age:");

            return new User(name, dateOfBirth, age);
        }

        

        
    }
}
