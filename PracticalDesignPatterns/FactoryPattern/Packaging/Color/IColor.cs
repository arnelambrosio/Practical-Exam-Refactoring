using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern.Packaging.Color
{
    public interface IColor
    {
        IColor Create();
    }
}
