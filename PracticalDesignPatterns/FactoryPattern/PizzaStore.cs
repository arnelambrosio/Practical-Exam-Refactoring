using PracticalDesignPatterns.FactoryPattern.Ingredients;
using PracticalDesignPatterns.FactoryPattern.PizzaVarieties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern
{
    public abstract class PizzaStore
    {
        internal IIgredientsProvider Ingredients;
        internal IFlavor Flavor;
        internal PizzaVariety Variety;

        public PizzaStore(IIgredientsProvider ingredientsProvider, IFlavor flavor)
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
