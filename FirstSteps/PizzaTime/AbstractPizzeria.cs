using System;
using ArrayForTask;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime
{
    public abstract class AbstractPizzeria
    {
        public string Name { get; private set; }

        public Queue<AbstractOrder> orders = new Queue<AbstractOrder>();

        public int ordersCount;

        public bool working = false;
        public abstract void AddNewOrder();
        public abstract void Work();

        public AbstractPizzeria(string name)
        {
            Name = name;
        }




    }
}
