using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorForDucks
{
    public class Chicken:Bird
    {
        public override string GetDescription()
        {
            return "Chicken";
        }

        public override double Cost()
        { return 3.99; }
    }
}
