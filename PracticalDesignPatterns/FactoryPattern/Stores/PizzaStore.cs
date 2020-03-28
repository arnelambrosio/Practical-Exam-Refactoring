using PracticalDesignPatterns.FactoryPattern.Ingredients;
using PracticalDesignPatterns.FactoryPattern.Packaging;
using PracticalDesignPatterns.FactoryPattern.PizzaVarieties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern.Stores
{
    public abstract class PizzaStore
    {
        internal IStoreIgredients Ingredients;
        internal IIngredientMixer Flavor;
        internal IPizzaVariety Variety;
        internal IBoxProvider Packaging;

        public PizzaStore(IStoreIgredients ingredientsProvider, IIngredientMixer flavor, IBoxProvider packaging)
        {
            Ingredients = ingredientsProvider;
            Flavor = flavor;
            Packaging = packaging;
        }

        public virtual string Bake()
        {
            return "Baking at 135 degree Celsius for 25 minutes";
        }

        public virtual string Box()
        {
            return $"Putting pizza in {Packaging.BoxColor.Create()} coloured box";
        }

        public virtual string Cut()
        {
            return "Cutting into diagonal pieces";
        }

        public virtual string ProcessOrder()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"Prepare()\nPreparing Pizzeria A style {Variety.Description} Using\n{Prepare()}\n");
            result.Append($"Bake()\n{Bake()}\n");
            result.Append($"Cut()\n{Cut()}\n");
            result.Append($"Box()\n{Box()}\n\n\n");

            return result.ToString();

        }

        public string Prepare()
        {
            string flavor = Flavor.Add(Ingredients, Variety);
            return flavor;
        }
    }
}
