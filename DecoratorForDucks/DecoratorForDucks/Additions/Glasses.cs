using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorForDucks
{
   public class Glasses:Bird       //в очках
    {
        Bird _bird;

        public Glasses(Bird bird)
        { _bird = bird; }

        public override string GetDescription()
        {
            return _bird.GetDescription() + ", in glasses";
        }

        public override double Cost()
        {
            return _bird.Cost() + 0.25;
        }
    }
}
