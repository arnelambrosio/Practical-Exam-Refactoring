using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalDesignPatterns.FactoryPattern.Ingredients
{
    public class Cucumber : Veggies
    {
        public override string Description => "Cucumber";
    }

    public class Olives : Veggies
    {
        public override string Description => "Olives";
    }

    public class Onions : Veggies
    {
        public override string Description => "Onions";
    }

    public class BellPepper : Veggies
    {
        public override string Description => "Bell Peppers";
    }
}
