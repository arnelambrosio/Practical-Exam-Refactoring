using NUnit.Framework;
using PracticalDesignPatterns.FactoryPattern;
using PracticalDesignPatterns.FactoryPattern.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Test
{
    [TestFixture]
    public class StoreIngredientsFactoryTest
    {
        IStoreIgredients _factory = null;

        [SetUp]
        public void Init()
        {
        }

        [Test]
        public void Return_Null_When_Store_Has_No_Ingredients_Setup()
        {
            var ing = _factory = new StoreIngredientsFactory().GetIngredients(Store.PizzeriaC);

            Assert.IsNull(ing);
        }

        [Test]
        public void Return_Not_Null_When_Store_Has_Ingredients_Setup()
        {
            var ing = _factory = new StoreIngredientsFactory().GetIngredients(Store.PizzeriaA);

            Assert.IsNotNull(ing);
        }
    }
}
