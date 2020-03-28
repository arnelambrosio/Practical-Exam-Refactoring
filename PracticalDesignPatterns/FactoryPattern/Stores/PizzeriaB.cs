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
    public class PizzeriaB : PizzaStore, IPizzaFactory
    {
        public PizzeriaB() : base(
            new StoreIngredientsFactory().GetIngredients(Store.PizzeriaB)
            ,new VarietyIngredients()
            ,new PizzeriaBPackaging()
            )
        {
        }
        public override string Bake()
        {
            return base.Bake();
        }

        public override string Box()
        {
            return base.Box();
        }

        public override string Cut()
        {
            return base.Cut();
        }

        public Pizza PlaceOrder(IPizzaVariety variety)
        {
            Variety = variety;
            string orderDescription = ProcessOrder();

            return new Pizza(this.ToString(),Variety.Description,orderDescription);

        }

        public override string ProcessOrder()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"Prepare()\nPreparing Pizzeria B style {Variety.Description} Using\n{Prepare()}\n");
            result.Append($"Bake()\n{Bake()}\n");
            result.Append($"Cut()\n{Cut()}\n");
            result.Append($"Box()\n{Box()}\n\n\n");

            return result.ToString();

        }

        public override string ToString()
        {
            return "Pizzeria B";
        }
    }
}
