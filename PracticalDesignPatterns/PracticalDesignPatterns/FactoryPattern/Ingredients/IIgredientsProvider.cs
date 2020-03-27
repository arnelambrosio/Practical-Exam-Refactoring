using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern.Ingredients
{
    public interface IIgredientsProvider
    {
        Dictionary<IngredientsCategory, string> ProvideIngredients { get; }
    }
}
