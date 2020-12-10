using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime
{
    public class OnlineOrder : AbstractOrder
    {
        public string clientName;
        public string phoneNumber;

        public OnlineOrder(Pizza[] order, int orderNumber, string clientName, string phoneNumber) : base(order, orderNumber)
        {
            this.clientName = clientName;
            this.phoneNumber = phoneNumber;
        }

    }
}
