using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern.Packaging
{
    public interface IPackagingFactory
    {
        IBoxProvider GetBoxProvider(Store store);
    }
}
