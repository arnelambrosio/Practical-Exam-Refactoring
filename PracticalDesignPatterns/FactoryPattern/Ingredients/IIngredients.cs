using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern.Ingredients
{
    public interface IIngredients
    {
        Dictionary<IngredientsCategory, IList<string>> GetIngredients(Store store, PizzaVariety variety);
    }
}
