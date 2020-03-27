using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern.Packaging.Color
{
    public class Red : IColor
    {
        public IColor Create()
        {
            return new Red();
        }

        public override string ToString()
        {
            return "Red";
        }
    }
}
