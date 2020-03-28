using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern.Packaging
{
    public interface IBoxFactory
    {
        IBoxProvider GetBoxProvider(Store store);
    }
}
