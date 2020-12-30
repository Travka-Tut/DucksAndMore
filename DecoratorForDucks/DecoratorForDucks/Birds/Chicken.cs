using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorForDucks
{
    public class Chicken:Bird             //создаем курицу
    {
        public override string GetDescription()      //переопределяем описание
        {
            return "Chicken";
        }

        public override double Cost()             //и цену
        { return 3.99; }
    }
}
