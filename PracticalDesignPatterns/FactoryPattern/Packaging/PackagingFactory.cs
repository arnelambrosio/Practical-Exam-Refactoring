using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern.Packaging
{
    public class PackagingFactory : IPackagingFactory
    {
        public IBoxProvider GetBoxProvider(Store store)
        {
            IBoxProvider box = null;

            switch (store)
            {
                case Store.PizzeriaA:
                    box = new PizzeriaAPackaging();
                    break;
                case Store.PizzeriaB:
                    box = new PizzeriaBPackaging();
                    break;
            }

            return box;
        }
    }
}
