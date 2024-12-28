using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4.FactoryPattern
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }

        abstract Pizza CreatePizza(string type);
        //{
        //    Pizza pizza = null;

        //    if (type == "cheese")
        //    {
        //        pizza = new CheesePizza();
        //    }
        //    else if (type == "pepperoni")
        //    {
        //        pizza = new PepperoniPizza();
        //    }
        //    else if (type == "clam")
        //    {
        //        pizza = new ClamPizza();
        //    }
        //    else if (type == "veggie")
        //    {
        //        pizza = new VeggiePizza();
        //    }
        //    return pizza;
        //}
    }
}
