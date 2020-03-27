using PracticalDesignPatterns.FactoryPattern.Packaging.Color;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern.Packaging
{
    public class PizzeriaAPackaging : IBoxProvider
    {
        public IColor Color { get => new Red(); }
    }
}
