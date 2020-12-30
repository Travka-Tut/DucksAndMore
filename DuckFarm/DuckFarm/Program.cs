using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DuckFarm.Ducks;

namespace DuckFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаем разных уток и заставляем их рассказывать о себе
            Duck duck = new Duck();
            Console.WriteLine(duck.Name+":\n");                    
            duck.Fly();
            duck.Quack();
            duck.Swim();

            WoodenDuck woodenduck = new WoodenDuck();
            Console.WriteLine("\n"+woodenduck.Name + ":\n");
            woodenduck.Fly();
            woodenduck.Quack();
            woodenduck.Swim();

            IronDuck ironduck = new IronDuck();
            Console.WriteLine("\n" + ironduck.Name + ":\n");
            ironduck.Fly();
            ironduck.Quack();
            ironduck.Swim();
            Console.ReadLine();
        }
    }
}
