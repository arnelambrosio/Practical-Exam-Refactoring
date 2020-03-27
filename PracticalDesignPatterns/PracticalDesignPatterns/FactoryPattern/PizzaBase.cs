using PracticalDesignPatterns.FactoryPattern.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern
{
    public abstract class PizzaBase
    {
        internal PizzaVariety Variety;
        internal IIgredientsProvider Ingredients;
        internal IFlavor Flavor;

        public PizzaBase(IIgredientsProvider ingredientsProvider, IFlavor flavor)
        {
            Ingredients = ingredientsProvider;
            Flavor = flavor;
        }

        public virtual string Bake()
        {
            return "Baking at 135 degree Celsius for 25 minutes";
        }

        public virtual string Box()
        {
            return "Putting pizza in Red coloured box";
        }

        public virtual string Cut()
        {
            return "Cutting into diagonal pieces";
        }

        public virtual string ProcessOrder()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"Prepare()\nPreparing Pizzeria A style {Variety.ToString()} Using\n{Prepare()}\n");
            result.Append($"Bake()\n{Bake()}\n");
            result.Append($"Cut()\n{Cut()}\n");
            result.Append($"Box()\n{Box()}\n\n\n");

            return result.ToString();

        }

        public string Prepare()
        {
            string flavor = Flavor.Add(Ingredients.ProvideIngredients, Variety);
            return flavor;
        }
    }
}
