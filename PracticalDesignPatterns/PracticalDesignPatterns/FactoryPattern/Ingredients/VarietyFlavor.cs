using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern.Ingredients
{
    public class VarietyFlavor : IFlavor
    {
        public string Add(Dictionary<IngredientsCategory, string> ingredients, PizzaVariety variety)
        {
            string flavor = "";
            var ing = ingredients;
            switch (variety)
            {
                case PizzaVariety.Cheeze:
                    flavor = $"{IngredientsCategory.Dough.ToString()}:{ing[IngredientsCategory.Dough]}," +
                        $"{IngredientsCategory.Cheese.ToString()}:{ing[IngredientsCategory.Cheese]}," +
                        $"{IngredientsCategory.Sauce.ToString()}:{ing[IngredientsCategory.Sauce]}," +
                        $"{IngredientsCategory.Veggies.ToString()}:{ing[IngredientsCategory.Veggies]}";
                    break;
                case PizzaVariety.Clam:
                    flavor = $"{IngredientsCategory.Dough.ToString()}:{ing[IngredientsCategory.Dough]}," +
                        $"{IngredientsCategory.Clam.ToString()}:{ing[IngredientsCategory.Clam]}," +
                        $"{IngredientsCategory.Sauce.ToString()}:{ing[IngredientsCategory.Sauce]}," +
                        $"{IngredientsCategory.Cheese.ToString()}:{ing[IngredientsCategory.Cheese]}";
                    break;
                case PizzaVariety.Veggie:
                    flavor = $"{IngredientsCategory.Dough.ToString()}:{ing[IngredientsCategory.Dough]}," +
                        $"{IngredientsCategory.Sauce.ToString()}:{ing[IngredientsCategory.Sauce]}," +
                        $"{IngredientsCategory.Veggies.ToString()}:{ing[IngredientsCategory.Veggies]}";
                    break;
            }

            return flavor;
        }
    }
}
