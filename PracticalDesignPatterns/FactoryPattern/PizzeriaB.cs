using PracticalDesignPatterns.FactoryPattern.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern
{
    public class PizzeriaB : PizzaBase, IPizzaFactory
    {
        public PizzeriaB() : base(
            new IngredientFactory().GetIngredients(Store.PizzeriaA),
            new VarietyFlavor())
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

        public string PlaceOrder(PizzaVariety variety)
        {
            Variety = variety;

            return ProcessOrder();
        }

        public override string ProcessOrder()
        {
            StringBuilder result = new StringBuilder();
            result.Append($"Prepare()\nPreparing Pizzeria B style {Variety.ToString()} Using\n{Prepare()}\n");
            result.Append($"Bake()\n{Bake()}\n");
            result.Append($"Cut()\n{Cut()}\n");
            result.Append($"Box()\n{Box()}\n\n\n");

            return result.ToString();

        }
    }
}
