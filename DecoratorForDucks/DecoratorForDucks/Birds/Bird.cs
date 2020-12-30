using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorForDucks
{
    public abstract class Bird          //хз, как работает, но очень нужен
    {
        //public string _description = "No Bird for sale";

        public virtual string GetDescription()
        {
            return "No Bird for sale";
        }

        public abstract double Cost();
    }
}
