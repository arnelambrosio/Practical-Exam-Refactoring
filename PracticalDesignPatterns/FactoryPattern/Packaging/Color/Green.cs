using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern.Packaging.Color
{
    public class Green : IColor
    {
        public IColor Create()
        {
            return new Green();
        }

        public override string ToString()
        {
            return "Green";
        }
    }
}
