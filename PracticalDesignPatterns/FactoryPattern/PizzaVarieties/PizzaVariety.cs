using PracticalDesignPatterns.FactoryPattern.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern.PizzaVarieties
{
    public abstract class PizzaVariety
    {
        public abstract string Description { get; }
        public Dough Dough { get; set; }
        public Sauce Sauce { get; set; }
    }
}
