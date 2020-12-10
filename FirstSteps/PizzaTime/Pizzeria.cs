using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime
{
    public class Pizzeria : AbstractPizzeria
    {
        Oven oven = new Oven();
        Notitfication notice = new Notitfication();


        public Pizzeria(string name) : base(name) { }


        public AbstractOrder BuildOrder()
        {
            ordersCount++;
            AbstractOrder order = new OfflineOrder(new Pizza[] {Pizza.Margarita, Pizza.Margarita }, ordersCount);
            order.OnCooked += notice.Alert;

            return order;


        }
        public override void AddNewOrder()
        {
            //сотрудник поолучает от покупателя данные заказа 
            //или клиент вводит данные через интернет
            //и заказ добавляется в очередь

            var order = BuildOrder();
            orders.Enqueue(order);
            Console.WriteLine($"Order number {order.orderNumber} added! ");
            
            if (working == false)
            {
                working = true;
                Task workTask = new Task(Work);
                workTask.Start();
            }
        }

        public override void Work()
        {
            while (orders.Count != 0)
            {
                var currentOrder = orders.Dequeue();

                foreach (var pizza in currentOrder.order)
                {
                    oven.Bake(pizza);
                }

                currentOrder.Ready();
                currentOrder.OnCooked -= notice.Alert;
            }

            working = false;
        }

    }


}
