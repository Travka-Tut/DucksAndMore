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
            Console.WriteLine("Живая утка:\n");
            Duck duck = new Duck();
            duck.Fly();
            duck.Quack();
            duck.Swim();
            Console.WriteLine("\n\nДеревянная уточка:\n");
            WoodenDuck wodenduck = new WoodenDuck();
            wodenduck.Fly();
            wodenduck.Quack();
            wodenduck.Swim();
            Console.WriteLine("\n\nЖелезная утка:\n");
            IronDuck ironduck = new IronDuck();
            ironduck.Fly();
            ironduck.Quack();
            ironduck.Swim();
            Console.ReadLine();
        }
    }
}
