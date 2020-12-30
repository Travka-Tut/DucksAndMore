using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorForDucks
{
    class Duck : Bird            //утка - как и курица
    {
        public override string GetDescription()
        {
            return "Duck";
        }

        public override double Cost()
        {
            return 5.99;
        }
    }
}
