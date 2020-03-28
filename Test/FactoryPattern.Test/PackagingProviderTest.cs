using NUnit.Framework;
using PracticalDesignPatterns.FactoryPattern;
using PracticalDesignPatterns.FactoryPattern.Packaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Test
{
    [TestFixture]
    public class PackagingProviderTest
    {
        [SetUp]
        public void Initialize()
        {

        }

        [Test]
        public void Return_Null_When_Provider_Not_Exist()
        {
            IBoxProvider box = new PackagingFactory().GetBoxProvider(Store.PizzeriaC);

            Assert.IsNull(box);
        }

        [Test]
        public void Return_Not_Null_When_Provider_Exist()
        {
            IBoxProvider box = new PackagingFactory().GetBoxProvider(Store.PizzeriaA);

            Assert.IsNotNull(box);
        }
    }
}
