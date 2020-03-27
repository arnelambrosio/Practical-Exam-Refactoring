﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern
{
    public class PizzaStoreFactory : Pizzeria
    {
       
        public override IPizzaFactory GetPizzaMaker(Store storeType)
        {
            IPizzaFactory store = null;

            switch (storeType)
            {
                case Store.PizzeriaA:
                    store = new PizzeriaA();
                    break;
                case Store.PizzeriaB:
                    store = new PizzeriaB();
                    break;
                default:
                    break;
            }

            return store;
        }
    }
}
