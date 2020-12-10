using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime
{
    class Program
    {
        static void Main()
        {
            var pizzeria = new Pizzeria("Tashir");

            pizzeria.AddNewOrder();

            pizzeria.AddNewOrder();

            Console.ReadKey();

            
        }

        
    }

    
}
