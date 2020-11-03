using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorForDucks
{
    class BirdsShop
    {

        static void Main(string[] args)
        {
            Bird bird = new Turkey();
            Console.WriteLine(bird.GetDescription()+Environment.NewLine
                +bird.Cost());

            Bird bird2 = new Duck();
            bird2 = new Slippers(bird2);
            bird2 = new Ribbon(bird2);
            bird2 = new Ribbon(bird2);
            Console.WriteLine(bird2.GetDescription() + Environment.NewLine
                + bird2.Cost());

            Bird bird3 = new Chicken();
            bird3 = new Glasses(bird3);
            bird3 = new Ribbon(bird3);
            bird3 = new Slippers(bird3);
            Console.WriteLine(bird3.GetDescription() + Environment.NewLine
                + bird3.Cost());

            Console.ReadLine();
        }
    }
}
