using PracticalDesignPatterns.FactoryPattern.PizzaVarieties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern.Ingredients
{
    public class VarietyIngredients : IIngredientMixer
    {
        public string Add(IStoreIgredients ing, IPizzaVariety variety)
        {
            string flavor = "";

            Type type = variety.GetType();

            if (type == typeof(CheesePizza))
            {
                flavor = $"{IngredientsCategory.Dough.ToString()}:{ing.CreateDough().Description}," +
                        $"{IngredientsCategory.Cheese.ToString()}:{ing.CreateCheese().Description}," +
                        $"{IngredientsCategory.Sauce.ToString()}:{ing.CreateSouce().Description}," +
                        $"{IngredientsCategory.Veggies.ToString()}:{string.Join(",", ing.CreateVeggies().Select(a => a.Description).ToList())}";
            }

            if (type == typeof(VeggiePizza))
            {
                flavor = $"{IngredientsCategory.Dough.ToString()}:{ing.CreateDough().Description}," +
                        $"{IngredientsCategory.Sauce.ToString()}:{ing.CreateSouce().Description}," +
                        $"{IngredientsCategory.Veggies.ToString()}:{string.Join(",", ing.CreateVeggies().Select(a => a.Description).ToList())}";
            }

            if (type == typeof(ClamPizza))
            {
                flavor = $"{IngredientsCategory.Dough.ToString()}:{ing.CreateDough().Description}," +
                         $"{IngredientsCategory.Clam.ToString()}:{ing.CreateClam().Description}," +
                        $"{IngredientsCategory.Sauce.ToString()}:{ing.CreateSouce().Description}," +
                        $"{IngredientsCategory.Cheese.ToString()}:{ing.CreateCheese().Description}";
            }

            return flavor;
        }
    }
}
