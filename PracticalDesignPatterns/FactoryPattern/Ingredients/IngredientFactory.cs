using PracticalDesignPatterns.FactoryPattern.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern.Ingredients
{
    public class IngredientFactory : IIngredientsFactory
    {
        public IIgredientsProvider GetIngredients(Store storeType)
        {
            IIgredientsProvider ing = null;

            switch (storeType)
            {
                case Store.PizzeriaA:
                    ing = new PizzeriaAIngredients();
                    break;
                case Store.PizzeriaB:
                    ing = new PizzeriaBIngredients();
                    break;
            }

            return ing;
        }

        public IIgredientsProvider GetIngredients(PizzaStore store)
        {
            if (store.GetType() == typeof(PizzeriaA))
                return new PizzeriaAIngredients();

            if (store.GetType() == typeof(PizzeriaB))
                return new PizzeriaAIngredients();

            return null;
        }
    }
}
