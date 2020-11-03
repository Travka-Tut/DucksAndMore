using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorForDucks
{
    class Slippers : Bird        //в тапочках
    {
        Bird _bird;

        public Slippers(Bird bird)
        {
            _bird = bird;
        }

        public override string GetDescription()
        {
            return _bird.GetDescription() + ", in slippers";
        }

        public override double Cost()
        {
            return _bird.Cost() + 0.39;
        }
    }
}
