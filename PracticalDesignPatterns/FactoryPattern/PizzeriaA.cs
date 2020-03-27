using PracticalDesignPatterns.FactoryPattern.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern
{
    public class PizzeriaA : PizzaBase, IPizzaFactory
    {
        public PizzeriaA() : base(
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
    }
}
