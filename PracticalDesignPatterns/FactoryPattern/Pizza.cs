using PracticalDesignPatterns.FactoryPattern.PizzaVarieties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern
{
    public class Pizza
    {
        public Pizza(string store, string variety,string description)
        {
            Store = store;
            Variety = variety;
            Description = description;
        }
        public string Store { get; private set; }
        public string Variety { get; private set; }
        public string Description { get; private set; }
    }
}
