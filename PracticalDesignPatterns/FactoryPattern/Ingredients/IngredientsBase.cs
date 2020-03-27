using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern.Ingredients
{
    public abstract class IngredientsBase
    {
        public abstract IIgredientsProvider GetIngredients(Store storeType);
        public abstract IIgredientsProvider GetIngredients(PizzaStore store);
    }
}
