using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern
{
    public abstract class Pizzeria
    {
        public abstract IPizzaFactory GetPizzaMaker(Store storeType);

    }
}
