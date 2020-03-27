using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern
{
    public enum Store
    {
        PizzeriaA,
        PizzeriaB
    }

    public enum PizzaVariety
    {
        Cheeze,
        Clam,
        Veggie
    }

    public enum IngredientsCategory
    {
        Cheese,
        Clam,
        Dough,
        Sauce,
        Veggies
    }
}
