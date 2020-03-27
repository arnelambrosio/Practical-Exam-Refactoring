using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern.Ingredients
{
    public class PizzeriaBIngredients : IIgredientsProvider
    {
        public Dictionary<IngredientsCategory, string> ProvideIngredients =>
            new Dictionary<IngredientsCategory, string>()
            {
                { IngredientsCategory.Cheese, "Parmesan"},
                { IngredientsCategory.Clam, "Fresh Clam" },
                { IngredientsCategory.Dough, "Deep Dish" },
                { IngredientsCategory.Sauce, "Plum Tomato" },
                { IngredientsCategory.Veggies, "Cucumber,Onions,Pepper" }
            };

    }
}
