using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern.Ingredients
{
    public class PizzeriaBIngredients : IIgredientsProvider
    {
        public Cheese CreateCheese()
        {
            return new Parmesan();
        }

        public Clam CreateClam()
        {
            return new FreshClam();
        }

        public Dough CreateDough()
        {
            return new DeepDish();
        }

        public Sauce CreateSouce()
        {
            return new PlumTomato();
        }

        public IList<Veggies> CreateVeggies()
        {
            return new List<Veggies>()
            {
                new Cucumber(),
                new Onions(),
                new BellPepper()
            };
        }
    }
}
