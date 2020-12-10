using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    class User
    {
        public string name;

        private List<SomethingColored> list = new List<SomethingColored>();

        public User(string name)
        {
            this.name = name;
        }


        public void Add(SomethingColored elem)
        {
            list.Add(elem);
            Console.WriteLine(elem.Name + " added!\n");
        }


        public void Clear()
        {
            list.Clear();
            Console.WriteLine("Collection is cleared!");
        }

        public void ShowInformation()
        {
            foreach (var i in list)
            {
                i.ShowInfo();
            }
        }

        public void ShowCollection()
        {
            Console.WriteLine(name + "'s collection:\n");
            foreach (var i in list)
            {
                Console.WriteLine(i.color + " " + i.Name);
            }
        }


        public void Hello()
        {
            Console.WriteLine("Hi " + name + "!\n");

        }

        public void Bye()
        {
            Console.WriteLine("Bye " + name);

        }

        
    }
}
