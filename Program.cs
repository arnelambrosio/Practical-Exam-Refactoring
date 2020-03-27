using PracticalDesignPatterns.FactoryPattern;
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
            string resultA = pizzeriaA.PlaceOrder(PizzaVariety.Cheeze);

            Console.WriteLine(resultA);
            Console.WriteLine(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::");

            IPizzaFactory pizzeriaB = new PizzaStoreFactory().GetPizzaMaker(Store.PizzeriaB);
            string resultB = pizzeriaB.PlaceOrder(PizzaVariety.Veggie);
            Console.WriteLine(resultB);
        }
    }
}
