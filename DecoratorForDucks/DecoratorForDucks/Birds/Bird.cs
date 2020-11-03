using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorForDucks
{
    public abstract class Bird
    {
        //public string _description = "No Bird for sale";

        public virtual string GetDescription()
        {
            return "No Bird for sale";
        }

        public abstract double Cost();
    }
}
