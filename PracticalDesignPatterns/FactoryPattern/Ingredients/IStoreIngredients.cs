using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern.Ingredients
{
    public interface IStoreIgredients
    {
        Cheese CreateCheese();
        Clam CreateClam();
        Dough CreateDough();
        Sauce CreateSouce();
        IList<Veggies> CreateVeggies();
    }
}
