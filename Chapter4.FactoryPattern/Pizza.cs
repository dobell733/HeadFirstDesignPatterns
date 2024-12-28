using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4.FactoryPattern
{
    abstract class Pizza
    {
        public void prepare() { Console.WriteLine("Preparing pizza."); }
        public void bake() { Console.WriteLine("Baking pizza."); }
        public void cut() { Console.WriteLine("Cutting pizza."); }
        public void box() { Console.WriteLine("Boxing pizza."); }
    }
}
