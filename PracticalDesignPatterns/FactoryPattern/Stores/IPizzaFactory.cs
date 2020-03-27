using PracticalDesignPatterns.FactoryPattern.PizzaVarieties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern.Stores
{
    public interface IPizzaFactory
    {
        string PlaceOrder(IPizzaVariety variety);
    }
}
