using PracticalDesignPatterns.FactoryPattern.PizzaVarieties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern.Ingredients
{
    public interface IFlavor
    {
        string Add(IIgredientsProvider ingredients, PizzaVariety variety);
    }
}
