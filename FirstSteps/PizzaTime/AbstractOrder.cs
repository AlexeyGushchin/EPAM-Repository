using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime
{
    public abstract class AbstractOrder
    {
        

        public event Action<AbstractOrder> OnCooked = delegate { };

        public Pizza[] order;
        public int orderNumber;

        public AbstractOrder(Pizza[] order, int orderNumber)
        {
            this.order = order;
            this.orderNumber = orderNumber;
        }

        public void Ready()
        {
            OnCooked?.Invoke(this);
        }


    }
}
