using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime
{
    public class OfflineOrder : AbstractOrder
    {
        public OfflineOrder(Pizza[] order, int orderNumber) : base (order, orderNumber) { }

    }
}
