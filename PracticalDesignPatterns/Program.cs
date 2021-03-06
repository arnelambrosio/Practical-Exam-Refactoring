﻿using PracticalDesignPatterns.FactoryPattern;
using PracticalDesignPatterns.FactoryPattern.Ingredients;
using PracticalDesignPatterns.FactoryPattern.PizzaVarieties;
using PracticalDesignPatterns.FactoryPattern.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            ImplementElectricKettle();

            ImplementFactoryPattern();

            Console.ReadKey();
        }

        static void ImplementElectricKettle()
        {
            var electricKettle = ElectricKettle.Instance;

            Console.WriteLine($"Kettle status is: {electricKettle.Status.ToString()}");
            Console.WriteLine($"Fill with water: {electricKettle.Fill()}");
            Console.WriteLine($"Kettle status is: {electricKettle.Status.ToString()}");
            Console.WriteLine($"Plug to AC power outlet: {electricKettle.Boil()}");
            Console.WriteLine($"Kettle status is: {electricKettle.Status.ToString()}");
            Console.WriteLine($"Drain water: {electricKettle.Drain()}");
            Console.WriteLine($"Kettle status is: {electricKettle.Status.ToString()}");

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

        }

        static void ImplementFactoryPattern()
        {
            IPizzaFactory pizzeriaA = new PizzaStoreFactory().GetPizzaMaker(Store.PizzeriaA);
            var resultA = pizzeriaA.PlaceOrder(new CheesePizza());
            Console.WriteLine(resultA.Description);

            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

            IPizzaFactory pizzeriaB = new PizzaStoreFactory().GetPizzaMaker(Store.PizzeriaB);
            var resultB = pizzeriaB.PlaceOrder(new VeggiePizza());
            Console.WriteLine(resultB.Description);
        }
    }
}
