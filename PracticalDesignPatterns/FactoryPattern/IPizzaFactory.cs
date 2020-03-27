﻿using PracticalDesignPatterns.FactoryPattern.PizzaVarieties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern
{
    public interface IPizzaFactory
    {
        string PlaceOrder(PizzaVariety variety);
    }
}
