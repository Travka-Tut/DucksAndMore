using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorForDucks
{
   public class Ribbon:Bird   //в ленточке
    {
       Bird _bird;

       public Ribbon(Bird bird)
       {
           _bird = bird;
       }

       public override string GetDescription()
       { 
           return _bird.GetDescription() + ", in ribbon"; 
       }

       public override double Cost()
       {
           return _bird.Cost() + 0.15;
       }
    }
}
