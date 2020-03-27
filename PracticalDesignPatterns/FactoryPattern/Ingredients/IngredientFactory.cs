using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern.Ingredients
{
    public class IngredientFactory : IngredientsBase
    {
        public override IIgredientsProvider GetIngredients(Store storeType)
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
                default:
                    break;
            }

            return ing;
        }
    }
}
