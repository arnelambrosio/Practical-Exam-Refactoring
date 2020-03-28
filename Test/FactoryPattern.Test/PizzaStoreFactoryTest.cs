using NUnit.Framework;
using PracticalDesignPatterns.FactoryPattern;
using PracticalDesignPatterns.FactoryPattern.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Test
{
    [TestFixture]
    public class PizzaStoreFactoryTest
    {
        PizzaStoreFactory _storeFactory;

        [SetUp]
        public void Init()
        {
            _storeFactory = new PizzaStoreFactory();
        }

        [Test]
        public void Return_Null_When_Store_Not_Exist()
        {
            var store = _storeFactory.GetPizzaMaker(Store.PizzeriaC);

            Assert.IsNull(store);
        }

        [Test]
        public void Return_Not_Null_When_Store_Exist()
        {
            var store = _storeFactory.GetPizzaMaker(Store.PizzeriaA);

            Assert.IsNotNull(store);
        }

    }
}
