using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime
{
    public class Notitfication
    {
        public void Alert(AbstractOrder order)
        {
            var message = $"Order number {order.orderNumber} is ready!";
            string pizzas = "";

            foreach(var i in order.order)
            {
                pizzas = pizzas + " " + i;
            }
            

            OrdersWriter.GiveOrder(message + " " + pizzas);

            OnlineOrder online = order as OnlineOrder;

            if (online != null)
                MessageSender.SendMessage(message, online.phoneNumber);
        }
    }
}
