using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern.Ingredients
{
    public class PizzeriaAIngredients : IIgredientsProvider
    {
        public Dictionary<IngredientsCategory,string> ProvideIngredients =>
            new Dictionary<IngredientsCategory, string>()
            {
                { IngredientsCategory.Cheese,  "Mozarella" },
                { IngredientsCategory.Clam, "Frozen Clam" },
                { IngredientsCategory.Dough, "Thin Crust" },
                { IngredientsCategory.Sauce, "Cherry Tomato"},
                { IngredientsCategory.Veggies, "Olives,Onions,Pepper"}
            };
    }
}
