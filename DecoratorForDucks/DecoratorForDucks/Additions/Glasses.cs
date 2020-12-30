using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorForDucks
{
   public class Glasses:Bird       //в очках
    {
        Bird _bird;                 

        public Glasses(Bird bird)       //берем птицу (любую, какую сможешь поймать (зависит от размера яиц ;) ))
        { _bird = bird; }

        public override string GetDescription()      //получаем ее описание + добавляем, что она в очках
        {
            return _bird.GetDescription() + ", in glasses";
        }

        public override double Cost()           //получаем начальную цену + плата за модность
        {
            return _bird.Cost() + 0.25;
        }
    }
}
