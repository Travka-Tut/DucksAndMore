using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorForDucks
{
    class Turkey:Bird
    {

        public override string GetDescription()
        {
            return "Turkey";
        }

        public override double Cost()
        { return 4.69; }
    }
}
