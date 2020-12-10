using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PizzaTime
{
    public class Oven
    {
        public void Bake (Pizza pizza)
        {
            Thread.Sleep(TimeSpan.FromMilliseconds((int)pizza));
        }
    }
}
