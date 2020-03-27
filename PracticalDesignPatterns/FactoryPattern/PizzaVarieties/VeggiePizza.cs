using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern.PizzaVarieties
{
    public class VeggiePizza : IPizzaVariety
    {
        public string Description => "Veggie Pizza";
    }
}
