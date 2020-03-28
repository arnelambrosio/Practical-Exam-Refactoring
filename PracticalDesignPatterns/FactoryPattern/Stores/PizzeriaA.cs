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
    public class PizzeriaA : PizzaStore, IPizzaFactory
    {
        public PizzeriaA() : base(
            new StoreIngredientsFactory().GetIngredients(Store.PizzeriaA)
            ,new VarietyIngredients()
            ,new PizzeriaAPackaging()
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

            return new Pizza(this.ToString(),Variety.Description, orderDescription);
        }

        public override string ToString()
        {
            return "Pizzeria A";
        }
    }
}
