using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern.Ingredients
{
    public class PizzeriaAIngredients : IStoreIgredients
    {
        public Cheese CreateCheese()
        {
            return new Mozarella();
        }

        public Clam CreateClam()
        {
            return new FrozenClam();
        }

        public Dough CreateDough()
        {
            return new ThinCrust();
        }

        public Sauce CreateSouce()
        {
            return new CherryTomato();
        }

        public IList<Veggies> CreateVeggies()
        {
            return new List<Veggies>()
            {
                new Olives(),
                new Onions(),
                new BellPepper()
            };
        }
    }
}
