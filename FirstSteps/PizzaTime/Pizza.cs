using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime
{
    public enum Pizza : int
    {
        None = 0,
        Margarita = 5000,
        Pepperoni = 8000,
    }

    public enum Ingredients
    {
        None = 0,
        Dough,
        Sauce,
        Chees,
        Pepperoni
    }
}
