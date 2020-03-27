using PracticalDesignPatterns.FactoryPattern.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern.PizzaVarieties
{
    public interface IPizzaVariety
    {
        string Description { get; }
    }
}
