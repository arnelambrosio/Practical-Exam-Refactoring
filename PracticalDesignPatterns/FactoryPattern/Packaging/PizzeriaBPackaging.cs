using PracticalDesignPatterns.FactoryPattern.Packaging.Color;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern.Packaging
{
    public class PizzeriaBPackaging : IBoxProvider
    {
        public IColor BoxColor => new Green();
    }
}
